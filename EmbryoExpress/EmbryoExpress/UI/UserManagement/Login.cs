using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using EmbryoExpress.Properties;
using EmbryoExpress.SysClass;

namespace EmbryoExpress.UI.UserManagement
{
    public partial class Login : DevComponents.DotNetBar.Office2007Form
    {
        public Login()
        {
            InitializeComponent();
            AddUser();
            //Icon = Properties.Resources.NovoExpress;
            this.Text = string.Format(Resources.Login, Application.ProductName);
            this.comboBoxEx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAutoComplete_KeyPress);
            InitializeComboTree();
        }

        private void cbAutoComplete_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            this.AutoComplete(this.comboBoxEx1, e);
        }

        private void AddUser()
        {
            var users = Program.SysConfig.UserConfig.GetSortedUsers(false).Select(u => u.UserName);
            foreach (string item in users)
            {
                comboBoxEx1.Items.Add(item);
            }

            // find last login user
            User lastLogin = Program.SysConfig.LoginUser;

            // set last login user as selection if exists and not service engineer
            if (lastLogin != null && !Program.SysConfig.UserConfig.IsServiceengineerLogin())
                comboBoxEx1.SelectedItem = lastLogin.UserName;

            // set default selection
            if (comboBoxEx1.SelectedIndex == -1 && comboBoxEx1.Items.Count > 0) comboBoxEx1.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = comboBoxEx1.Text;
            string password = textBoxPassword.Text;
            userName = userName.Trim();
            if (userName == string.Empty)
            {
                MessageBox.Show(Resources.StrInputUserName, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Program.SysConfig.UserConfig.IsPasswordOk(userName, password))
            {
                return;
            }
            Program.SysConfig.AutoLogin = checkBoxX1.Checked;
            Program.SysConfig.LoginUser = Program.SysConfig.UserConfig.GetUserFromName(userName);
            this.DialogResult = DialogResult.OK;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            this.textBoxPassword.Focus();
        }

        private void userName_Changed(object sender, EventArgs e)
        {
            string userName = comboBoxEx1.Text.Trim();
            if (UserConfig.IsServiceengineer(userName))
            {
                checkBoxX1.Checked = false;
                checkBoxX1.Enabled = false;
            }
            else
            {
                checkBoxX1.Enabled = true;
            }
        }        

        /// <summary>
        /// auto complete combobox
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="e"></param>
        public void AutoComplete(ComboBox cb, System.Windows.Forms.KeyPressEventArgs e)
        {
            string strFindStr = "";

            if (cb.SelectionLength == 0)
                strFindStr = cb.Text + e.KeyChar;
            else
                strFindStr = cb.Text.Substring(0, cb.SelectionStart) + e.KeyChar;

            int intIdx = -1;

            // find the string in the ComboBox list.
            intIdx = cb.FindString(strFindStr);

            if (intIdx != -1)
            {
                cb.SelectedText = "";
                cb.SelectedIndex = intIdx;
                cb.SelectionStart = strFindStr.Length;
                cb.SelectionLength = cb.Text.Length;
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        /// <summary>
        /// initialize combotree
        /// </summary>
        private void InitializeComboTree()
        {
            //UserGroup group = Program.SysConfig.UserConfig.RootUserGroup;
            //if (group != null)
            //{
            //    Node rootNode = NovoCyte.UI.UserManagement.AddUser.GroupNode(group);
            //    NovoCyte.UI.UserManagement.AddUser.IterativeChildGroup(ref rootNode, group);
            //    rootNode.ExpandAll();
            //    this.comboTreeUserGroup.AdvTree.Nodes.Add(rootNode);
            //    rootNode.Checked = true;
            //    this.comboTreeUserGroup.SelectedNode = rootNode;
            //}
        }

        private void comboTreeUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Node node = this.comboTreeUserGroup.SelectedNode;
            //UserGroup group = node.Tag as UserGroup;
            //if (group != null)
            //{
            //    string lastSelectUser = comboBoxEx1.Text.Trim(); 
            //    comboBoxEx1.Items.Clear();
            //    comboBoxEx1.Items.AddRange(group.GetAllChildUsers(false).Select(u => u.UserName).ToArray());
            //    // 若选中的用户组内包含用户框内的用户，则用户框不更新
            //    if (comboBoxEx1.Items.Contains(lastSelectUser))
            //    {
            //        comboBoxEx1.SelectedItem = lastSelectUser;
            //    }
            //    else if (comboBoxEx1.Items.Count > 0)
            //    {
            //        comboBoxEx1.SelectedIndex = 0;
            //    }
            //}                                  
        }
    }
}
