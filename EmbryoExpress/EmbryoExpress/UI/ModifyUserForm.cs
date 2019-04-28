using DevComponents.DotNetBar;
using EmbryoExpress.Properties;
using EmbryoExpress.SysClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress.UI
{
    public partial class ModifyUserForm : Office2007Form
    {
        private bool _needOldPassworsd;
        private string _userName;
        private bool _oldPsswordClick = false;
        private bool _newPassword1Click = false;
        private bool _newPassword2Click = false;
        private int oldcbxUserRole = -1;
        public ModifyUserForm(string userName, bool putOldPassword)
        {
            InitializeComponent();

            cbxUserRole.Items.Add(Resources.CommonUser);
            cbxUserRole.Items.Add(Resources.AdminUser);
            cbxUserRole.Enabled = false;

            _userName = userName;
            _needOldPassworsd = putOldPassword;
            textBoxOldPassword.ReadOnly = !putOldPassword;
            textBoxUserNameInPut.Text = userName;

            if (Program.SysConfig.UserConfig.IsAdminLogin())
            {
                cbxUserRole.Enabled = true;
                if (UserConfig.IsSystemAdmin(userName))
                {
                    textBoxUserNameInPut.ReadOnly = true;
                    cbxUserRole.Enabled = false;
                }
                else if (UserConfig.IsServiceengineer(userName))
                {
                    textBoxOldPassword.Enabled = false;
                    textBoxNewPassword1.Enabled = false;
                    textBoxPassword2.Enabled = false;
                    textBoxUserNameInPut.ReadOnly = true;
                    cbxUserRole.Enabled = false;
                }
            }

            oldcbxUserRole = (int)Program.SysConfig.UserConfig.GetUserFromName(userName).UserRole;
            cbxUserRole.SelectedIndex = (oldcbxUserRole == 0) ? 0 : 1;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string oldPsw = textBoxOldPassword.WatermarkEnabled ? null : textBoxOldPassword.Text;
            string newPsw1 = textBoxNewPassword1.WatermarkEnabled ? null : textBoxNewPassword1.Text;
            string newPsw2 = textBoxPassword2.WatermarkEnabled ? null : textBoxPassword2.Text;
            bool changePassword = _newPassword1Click || _newPassword2Click;

            string newUserName = textBoxUserNameInPut.Text;
            bool changeUser = false;

            newUserName = newUserName.Trim();
            if (_userName.ToUpper() != newUserName.ToUpper())
            {
                changeUser = true;
            }
            bool isLoginUserChangeRole = false;
            if (Program.SysConfig.LoginUser.UserName == _userName && oldcbxUserRole != cbxUserRole.SelectedIndex)
            {
                isLoginUserChangeRole = true;
            }

            if (Program.SysConfig.UserConfig.ModifyUserInfo(_userName, newUserName, oldPsw, newPsw1, newPsw2,
                _needOldPassworsd, changeUser, changePassword, 
                (EmbryoExpress.SysClass.User.UserRoleType)cbxUserRole.SelectedIndex))
            {
                MessageBox.Show("确定", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isLoginUserChangeRole)
                {
                    Program.SysConfig.RaiseUserRoleChangedEvent();
                }
                if (this.Owner != null)
                {
                    if (isLoginUserChangeRole)
                    {
                        this.Owner.Close();
                        this.Owner.Dispose();
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void userName_Changed(object sender, EventArgs e)
        {
            string temp = textBoxUserNameInPut.Text.ToUpper();
            temp = temp.Trim();
            if (_userName.ToUpper() != temp)
            {
                buttonChange.Enabled = true;
            }
            else if (!(_oldPsswordClick || _newPassword1Click || _newPassword2Click))
            {
                buttonChange.Enabled = false;
            }
        }

        private void OldPassword_Enter(object sender, EventArgs e)
        {
            textBoxOldPassword.WatermarkEnabled = false;
            _oldPsswordClick = true;
            buttonChange.Enabled = true;
        }

        private void newPassword1_Enter(object sender, EventArgs e)
        {
            textBoxNewPassword1.WatermarkEnabled = false;
            _newPassword1Click = true;
            buttonChange.Enabled = true;
        }

        private void newPassword2_Enter(object sender, EventArgs e)
        {
            textBoxPassword2.WatermarkEnabled = false;
            _newPassword2Click = true;
            buttonChange.Enabled = true;
        }

        private void cbxUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonChange.Enabled = true;
        }
    }
}
