using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace ActiveDir
{
    public partial class FormSettings : Form
    {
        public static string _ouType = "";
        public FormSettings()
        {
            InitializeComponent();
            new ToolTip().SetToolTip(label_User_OU, "Укажите OU в которой будет создан пользователь нажмите кнопку Выберите OU" + "\n" + "и выберите в дереве Active Directory необходимое organisational Unit для создания пользователя");
            new ToolTip().SetToolTip(label_GPO_OUuser, "Укажите OU в которой будет создан пользователь scan и группа доступа" + "\n" + "нажмите кнопку Выберите OU и выберите в дереве Active Directory" + "\n" + "необходимое organisational Unit для создания пользователя и группы доступа к папке сканирования");
            new ToolTip().SetToolTip(label_GPO_OUgpo, "Укажите OU к которой будет прилинкована созданная политика" + "\n" + "нажмите кнопку Выберите OU и выберите в дереве Active Directory" + "\n" + "organisational Unit на которое должна быть прилинкована политика GPO");
            label_current_domain.Text = Properties.Settings.Default.currentDomain;
            numericUpDown_User_Password.Value = Properties.Settings.Default.userPasswordLength;
            textBox_GPO_FQDN.Text = Properties.Settings.Default.folderServerFQDN;
            textBox_mailServer.Text = Properties.Settings.Default.mailServer;
            textBox_mailFrom.Text = Properties.Settings.Default.mailFrom;
            textBox_mailTo.Text = Properties.Settings.Default.mailTo;
            label_User_OU_selected.Text = Properties.Settings.Default.fullUserPathAD;
            label_Folder_OU_User_selected.Text = Properties.Settings.Default.fullFolderPathAD;
            label_Folder_OU_GPO_selected.Text = Properties.Settings.Default.fullFolderPathGPO;

            if (!Properties.Settings.Default.mailCheckBox)
            {
                this.label_mailFrom.Enabled = false;
                this.textBox_mailFrom.Enabled = false;
                this.label_mailTo.Enabled = false;
                this.textBox_mailTo.Enabled = false;
                this.label_mailServer.Enabled = false;
                this.textBox_mailServer.Enabled = false;
            }
        }
        private bool SaveSettings(int _userPasswordLength, string _folderServerFQDN, bool _mailCheckBox, string _mailServer, string _mailFrom, string _mailTo)
        {
            Validate ValidMailTo = new Validate { __string_to_check = _mailTo, __regex_pattern = Mets.email_pattern };
            Validate ValidMailFrom = new Validate { __string_to_check = _mailFrom, __regex_pattern = Mets.email_pattern };
            Validate ValidFolderServerFQDN = new Validate { __string_to_check = _folderServerFQDN, __regex_pattern = Mets.serverFQDN_pattern };
            
            if (_userPasswordLength >= 6 && _userPasswordLength <= 30)
            {
                Properties.Settings.Default.userPasswordLength = _userPasswordLength;
            }
            else
            {
                MessageBox.Show("Проверьте длинну указанного пароля: она должна быть не менее 6 и не более 30 символов");
                return false;
            }
            if (ValidFolderServerFQDN.ValidateStringByPattern())
            {
                Properties.Settings.Default.folderServerFQDN = _folderServerFQDN;
            }
            else
            {
                MessageBox.Show("Проверьте корректность введённого адреса файлового сервера");
                return false;
            }
            Properties.Settings.Default.mailCheckBox = _mailCheckBox;
            if (_mailCheckBox)
            {
                if (ValidMailTo.ValidateStringByPattern() && ValidMailFrom.ValidateStringByPattern())
                {
                    Properties.Settings.Default.mailServer = _mailServer;
                    Properties.Settings.Default.mailFrom = _mailFrom;
                    Properties.Settings.Default.mailTo = _mailTo;
                }
                else
                {
                    MessageBox.Show("Проверьте корректность введённых email адресов");
                    return false;
                }
            }
            Properties.Settings.Default.Save();
            return true;
        }
        private void checkBoxSendPost_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mailCheckBox.Checked == true)
            {
                textBox_mailServer.Enabled = true;
                textBox_mailTo.Enabled = true;
                textBox_mailFrom.Enabled = true;
                label_mailServer.Enabled = true;
                label_mailTo.Enabled = true;
                label_mailFrom.Enabled = true;
            }
            else
            {
                textBox_mailServer.Enabled = false;
                textBox_mailTo.Enabled = false;
                textBox_mailFrom.Enabled = false;
                label_mailServer.Enabled = false;
                label_mailTo.Enabled = false;
                label_mailFrom.Enabled = false;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            SaveSettings(Convert.ToInt32(numericUpDown_User_Password.Value), textBox_GPO_FQDN.Text, checkBox_mailCheckBox.Checked, textBox_mailServer.Text, textBox_mailFrom.Text, textBox_mailTo.Text);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (SaveSettings(Convert.ToInt32(numericUpDown_User_Password.Value), textBox_GPO_FQDN.Text, checkBox_mailCheckBox.Checked, textBox_mailServer.Text, textBox_mailFrom.Text, textBox_mailTo.Text))
            {
                this.Close();
            }
        }
        private void FSOUform_Closed_fullUserPathAD(object sender, FormClosedEventArgs e)
        {
            label_User_OU_selected.Text = Properties.Settings.Default.fullUserPathAD;
        }
        private void FSOUform_Closed_fullFolderPathAD(object sender, FormClosedEventArgs e)
        {
            label_Folder_OU_User_selected.Text = Properties.Settings.Default.fullFolderPathAD;
        }
        private void FSOUform_Closed_fullFolderPathGPO(object sender, FormClosedEventArgs e)
        {
            label_Folder_OU_GPO_selected.Text = Properties.Settings.Default.fullFolderPathGPO;
        }
        private void button_User_OU_Click(object sender, EventArgs e)
        {
            _ouType = "userOU";
            FormSelectOU FSOU = new FormSelectOU();
            FSOU.FormClosed += new FormClosedEventHandler(FSOUform_Closed_fullUserPathAD);
            FSOU.StartPosition = FormStartPosition.CenterScreen;
            FSOU.ShowDialog();
        }
        private void button_GPO_OUuser_Click(object sender, EventArgs e)
        {
            _ouType = "gpoOUuser";
            FormSelectOU FSOU = new FormSelectOU();
            FSOU.FormClosed += new FormClosedEventHandler(FSOUform_Closed_fullFolderPathAD);
            FSOU.StartPosition = FormStartPosition.CenterScreen;
            FSOU.ShowDialog();
        }
        private void button_GPO_OUgpo_Click(object sender, EventArgs e)
        {
            _ouType = "gpoOUgpo";
            FormSelectOU FSOU = new FormSelectOU();
            FSOU.FormClosed += new FormClosedEventHandler(FSOUform_Closed_fullFolderPathGPO);
            FSOU.StartPosition = FormStartPosition.CenterScreen;
            FSOU.ShowDialog();
        }
    }
}
