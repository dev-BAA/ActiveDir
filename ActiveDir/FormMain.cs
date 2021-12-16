using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using Microsoft.GroupPolicy;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Xml;


namespace ActiveDir
{
    public partial class FormMain : Form
    {
        int NEF;
        public string strFIO;
        public string strr = "";
        public FormMain()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.textBox_common = new TextBox();
            Properties.Settings.Default.currentDomain = Domain.GetCurrentDomain().Name;
            Properties.Settings.Default.Save();
            InitializeComponent();
        }
        private void addUser()
        {
            string _DNS = Properties.Settings.Default.currentDomain;
            string _distinguishedName = Mets.DNStoDistinguishedName(_DNS);
            int _passLength = Properties.Settings.Default.userPasswordLength;
            string _userPathAD = Properties.Settings.Default.fullUserPathAD;

            string tFIO = textBox_addU.Text;
            string FIO = tFIO;
            string[] arrayFIO = tFIO.Split(' ');
            int x = arrayFIO.Length - 1;
            for (int n = 0; n <= x; n++)
            {
                if (n == 0)
                {
                    string tFIO0 = arrayFIO[n];
                    tFIO = Mets.Family(tFIO0) + ".";
                }
                if (n > 0)
                {
                    string tFIO12 = arrayFIO[n];
                    tFIO = tFIO + Mets.Initial(tFIO12);
                }
            }
            if (Class_AD.ADDoesUserExist(tFIO, _distinguishedName))
            {
                strr = strr + tFIO + " - существует" + Environment.NewLine;
                textBox_common.Text = strr;
                textBox_addU.Text = "";
            }
            if (!Class_AD.ADDoesUserExist(tFIO, _distinguishedName))
            {
                NEF = 0;
                string pass = Mets.CreatePasswordStrongPolicy(_passLength);
                Class_AD.ADCreateUser(_userPathAD, _DNS, FIO, tFIO, NEF, pass);
                strr = strr + "логин: " + tFIO + ", пароль: " + pass + Environment.NewLine;
                strr = strr + "---------------------------------------------------------------------------------------------------" + Environment.NewLine;
                textBox_common.Text = strr;
                if (Properties.Settings.Default.mailCheckBox)
                {
                    Mets.MaillWithoutAuth(Properties.Settings.Default.mailTo, Properties.Settings.Default.mailFrom, Properties.Settings.Default.mailServer, "ADD user", strr);
                }
                textBox_addU.Text = "";
            }
        }
        private void addMFU()
        {
            string _DNS = Properties.Settings.Default.currentDomain;
            string _distinguishedName = Mets.DNStoDistinguishedName(_DNS);
            string _folderPathAD = Properties.Settings.Default.fullFolderPathAD;
            string _folderPathGPO = Properties.Settings.Default.fullFolderPathGPO;
            string _folderPathAD_trim = _folderPathAD.Replace("LDAP://", "");
            string _folderPathGPO_trim = _folderPathGPO.Replace("LDAP://", "");
            string _folderServerFQDN = Properties.Settings.Default.folderServerFQDN;
            NEF = 0x10000;

            string pathNEW = _folderPathAD;
            string pathGPO = _folderPathGPO;
            string sharre = comboBox__addMFU_3.Text;
            string uSCAN = "scan-u" + textBox_addMFU_1.Text; // scan-U0001
            string grSCAN = "SMB-" + textBox_addMFU_2.Text + "-U" + textBox_addMFU_1.Text; // SMB-ОБУ-U0001
            string gpoSCAN = textBox_addMFU_2.Text + "-U" + textBox_addMFU_1.Text;  // ОБУ-U0001
            string gpoSCANname = ". Шара Ярлык - " + gpoSCAN;  // .Шара Ярлык - ОБУ-U0001
            string CNpath = "LDAP://CN=" + grSCAN + "," + _folderPathAD_trim;
            string cntSCAN = "CN = " + uSCAN + "," + _folderPathAD_trim;

            if (Class_AD.ADDoesUserExist(uSCAN, _distinguishedName))
            {
                strr = strr + uSCAN + " - существует" + Environment.NewLine;
                textBox_common.Text = strr;
                textBox_addMFU_1.Text = "";
            }
            if (!Class_AD.ADDoesUserExist(uSCAN, _distinguishedName))
            {
                string pass = Mets.CreatePassword(14);
                Class_AD.ADCreateUser(pathNEW, _DNS, uSCAN, uSCAN, NEF, pass);
                Class_AD.ADCreateGroup(pathNEW, grSCAN);
                Class_AD.ADAddMemberToGroup(CNpath, cntSCAN);
                Mets.UnzippFile(Application.StartupPath + "\\{01ECA7DE-BA34-412D-9B66-EC5D3C08CAF2}.zip", Application.StartupPath);
                Class_AD.GPOCreateAndLink(_DNS, pathGPO, gpoSCANname, grSCAN);
                Class_AD.GPOProperties(_DNS, gpoSCANname, gpoSCAN, _folderServerFQDN, sharre);

                strr = strr + "логин: " + _DNS + "\\" + uSCAN + ", пароль: " + pass + Environment.NewLine;
                strr = strr + "шара: " + sharre + "\\" + gpoSCAN + Environment.NewLine;
                strr = strr + "---------------------------------------------------------------------------------------------------" + Environment.NewLine;
                textBox_common.Text = strr;
                if (Properties.Settings.Default.mailCheckBox)
                {
                    Mets.MaillWithoutAuth(Properties.Settings.Default.mailTo, Properties.Settings.Default.mailFrom, Properties.Settings.Default.mailServer, "ADD scan user and GPO", strr);
                }
                textBox_addMFU_1.Text = "";
                textBox_addMFU_2.Text = "";
            }
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AB = new AboutBox1();
            AB.StartPosition = FormStartPosition.CenterScreen;
            AB.ShowDialog();
        }
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings FS = new FormSettings();
            FS.StartPosition = FormStartPosition.CenterScreen;
            FS.ShowDialog();
        }
        private void пользователяПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel_scan.Visible = false;
        }
        private void папкуСканированияпользователяScanГруппуИGpoДляМаппингаШарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel_scan.Visible = true;
        }
        private void button_createUser_Click(object sender, EventArgs e)
        {
            if (textBox_addU.Text != "")
            {
                addUser();
            }
            else if (textBox_addU.Text == "")
            {
                MessageBox.Show("Введите значение", "");
            }
        }
        private void button_createScan_Click(object sender, EventArgs e)
        {
            if (textBox_addMFU_1.Text != "" && textBox_addMFU_2.Text != "")
            {
                addMFU();
            }
            else if ((textBox_addMFU_1.Text == "") || (textBox_addMFU_2.Text == ""))
            {
                MessageBox.Show("Введите значение", "");
            }
        }
    }
}
