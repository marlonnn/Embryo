using DevComponents.DotNetBar;
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
    public partial class UserManagerForm : Office2007Form
    {
        public UserManagerForm()
        {
            InitializeComponent();

            RefreshUserList(true);
        }

        public void RefreshUserList(bool check = true, bool isInitialize = false)
        {
            listBoxUsers.Items.Clear();
            if (Program.SysConfig.UserConfig.IsAdminLogin())
            {
                //List<string> users = Program.SysConfig.UserConfig.GetAllUserWithoutServiceUser();
                //_users = GetAllUsers(_userGroup);
                List<User> users = Program.SysConfig.UserConfig.GetSortedUsers(false);

                foreach (User item in users)
                {
                    listBoxUsers.Items.Add(item.UserName);
                }
                buttonAdd.Enabled = true;
                if (check && listBoxUsers.SelectedItems.Count <= 0)
                {
                    buttonDelete.Enabled = false;
                    buttonModify.Enabled = false;
                }

            }
            else
            {
                listBoxUsers.Items.Add(Program.SysConfig.LoginUser.UserName);
                listBoxUsers.SelectedIndex = 0;
                buttonModify.Enabled = true;
            }
            if (Program.SysConfig.UserConfig.GetPossibleAddNo() <= 0)
            {
                buttonAdd.Enabled = false;
            }
        }

        private void listBoxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null) return;
            if (Program.SysConfig.UserConfig.IsAdminLogin())
            {
                buttonModify.Enabled = listBoxUsers.SelectedItems.Count > 0;
                buttonDelete.Enabled = listBoxUsers.SelectedItems.Count > 0;
            }
            if (Program.SysConfig.LoginUser == Program.SysConfig.UserConfig.GetUserFromName(listBoxUsers.SelectedItem.ToString())
                || UserConfig.IsSystemAdmin(listBoxUsers.SelectedItem.ToString()))
            {
                buttonDelete.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                RefreshUserList(true, true);
            }
            addUserForm.Dispose();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string userName = listBoxUsers.SelectedItem.ToString();
            //if (!Program.SysConfig.UserConfig.IsSysUserLogin())
            if (Program.SysConfig.LoginUser == Program.SysConfig.UserConfig.GetUserFromName(userName))
            {
                return;
            }
            if (Program.SysConfig.UserConfig.DeleteUser(userName))
            {
                RefreshUserList();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null) return;
            string userName = listBoxUsers.SelectedItem.ToString();
            // only when modify self need old password
            bool bPutOldPassword = string.Compare(userName, Program.SysConfig.LoginUser.UserName, true) == 0;

            ModifyUserForm frmModify = new ModifyUserForm(userName, bPutOldPassword);
            frmModify.Owner = this;

            if (frmModify.ShowDialog() == DialogResult.OK)
            {
                RefreshUserList(false, true);
            }
            frmModify.Dispose();

        }
    }
}
