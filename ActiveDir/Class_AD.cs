using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using Microsoft.GroupPolicy;
using System.IO;
using System.Xml;
using System.Windows.Forms;


namespace ActiveDir
{
    class Class_AD
    {
        public static bool ADDoesUserExist(string _username, string _DN)
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://" + _DN);
            DirectorySearcher ds = new DirectorySearcher(de);
            ds.SearchScope = SearchScope.Subtree;
            ds.Filter = "(&(objectClass=User)(sAMAccountName=" + _username + "))";
            if (ds.FindOne() == null) { return false; }
            else { return true; }
        }
        public static void ADCreateUser(string _path, string _DNS, string _FIO, string _username, int NON_EXPIRE_FLAG, string _passwrd)
        {
            using (DirectoryEntry ou = new DirectoryEntry(_path))
            {
                int NORMAL_ACCOUNT = 0x200;
                int PWD_NOTREQD = 0x20;
                DirectoryEntry user = ou.Children.Add("CN=" + _username, "user");
                user.Properties["sAMAccountName"].Value = _username;
                user.Properties["Name"].Value = _username;
                user.Properties["DisplayName"].Value = _FIO;
                _username = _username + "@" + _DNS;
                user.Properties["userPrincipalName"].Value = _username;
                user.Properties["userAccountControl"].Value = NORMAL_ACCOUNT | PWD_NOTREQD;
                user.CommitChanges();
                user.Invoke("SetPassword", new object[] { _passwrd });
                user.CommitChanges();
                if (NON_EXPIRE_FLAG == 0x10000)
                {
                    int val = (int)user.Properties["userAccountControl"].Value;
                    user.Properties["userAccountControl"].Value = val | NON_EXPIRE_FLAG;
                    user.CommitChanges();
                }
            }
        }
        public static void ADCreateGroup(string _groupPath, string _name)
        {
            using (DirectoryEntry ou = new DirectoryEntry(_groupPath))
            {
                DirectoryEntry group = ou.Children.Add("CN=" + _name, "group");
                group.Properties["sAmAccountName"].Value = _name;
                group.CommitChanges();
            }
        }
        public static void ADAddMemberToGroup(string _groupPath, string _newMember)
        {
            try
            {
                DirectoryEntry ent = new DirectoryEntry(_groupPath);
                ent.Properties["member"].Add(_newMember);
                ent.CommitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred." + "\n" + "{0}", e.Message);
                return;
            }
        }
        public static void GPOCreateAndLink(string _DNS, string _OUtoLink, string _GPOName, string _group)
        {
            GPDomain domain = new GPDomain(_DNS);
            Gpo gpo_mfu = domain.CreateGpo(_GPOName);
            GPPermission gp_mfugroup = new GPPermission(_group, GPPermissionType.GpoApply, false);
            GPPermission gp_authusers_remove = new GPPermission("Authenticated Users", GPPermissionType.GpoApply, false);
            GPPermission gp_authusers_addread = new GPPermission("Authenticated Users", GPPermissionType.GpoRead, false);
            GPPermissionCollection gppc = gpo_mfu.GetSecurityInfo();
            gppc.Add(gp_mfugroup);
            gppc.Remove(gp_authusers_remove);
            gppc.Add(gp_authusers_addread);
            gpo_mfu.SetSecurityInfo(gppc);
            Som som = domain.GetSom(_OUtoLink);
            som.LinkGpo(-1, gpo_mfu);
        }
        public static void GPOProperties(string _DNS, string _gpoSCANname, string _folderScan, string _fileserverName, string _share)
        {
            string pathDrives = Application.StartupPath + "\\{01ECA7DE-BA34-412D-9B66-EC5D3C08CAF2}\\DomainSysvol\\GPO\\User\\Preferences\\Drives\\Drives.xml";
            string pathShortcuts = Application.StartupPath + "\\{01ECA7DE-BA34-412D-9B66-EC5D3C08CAF2}\\DomainSysvol\\GPO\\User\\Preferences\\Shortcuts\\Shortcuts.xml";
            //Thread.Sleep(5000);
            var doc_dr = new XmlDocument();
            doc_dr.Load(pathDrives);
            XmlNodeList nds = doc_dr.GetElementsByTagName("Properties");
            foreach (XmlNode nd in nds)
            {
                if (nd.Attributes["path"].Value == "x")
                {
                    nd.Attributes["path"].Value = "\\\\" + _fileserverName + "\\" + _share + "\\" + _folderScan;
                }
                if (nd.Attributes["label"].Value == "x")
                {
                    nd.Attributes["label"].Value = _folderScan;
                }
            }
            doc_dr.Save(pathDrives);
            var doc_sh = new XmlDocument();
            doc_sh.Load(pathShortcuts);
            XmlNodeList ndss = doc_sh.GetElementsByTagName("Shortcut");
            foreach (XmlNode ndd in ndss)
            {
                if (ndd.Attributes["name"].Value == "x")
                {
                    ndd.Attributes["name"].Value = _folderScan;
                }
                if (ndd.Attributes["status"].Value == "x")
                {
                    ndd.Attributes["status"].Value = _folderScan;
                }
            }
            XmlNodeList ndsss = doc_sh.GetElementsByTagName("Properties");
            foreach (XmlNode nddd in ndsss)
            {
                if (nddd.Attributes["targetPath"].Value == "x")
                {
                    nddd.Attributes["targetPath"].Value = "\\\\" + _fileserverName + "\\" + _share + "\\" + _folderScan;
                }
                if (nddd.Attributes["shortcutPath"].Value == "x")
                {
                    nddd.Attributes["shortcutPath"].Value = "%DesktopDir%\\" + _folderScan;
                }
            }
            doc_sh.Save(pathShortcuts);
            GPDomain domain = new GPDomain(_DNS);
            GPSearchCriteria searchCriteria = new GPSearchCriteria();
            searchCriteria.Add(SearchProperty.MostRecentBackup, SearchOperator.Equals, true);
            BackupDirectory backupDir = new BackupDirectory(Application.StartupPath, BackupType.Gpo);
            GpoBackupCollection backups = backupDir.SearchGpoBackups(searchCriteria);
            Gpo gpoTarget = domain.GetGpo(_gpoSCANname);
            GPStatusMessageCollection statusMessages = null;
            gpoTarget.Import(backups[0], out statusMessages);
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\{01ECA7DE-BA34-412D-9B66-EC5D3C08CAF2}");
            dir.Delete(true);
        }
    }
}
