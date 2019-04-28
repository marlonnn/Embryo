using DevComponents.DotNetBar;
using EmbryoExpress.Properties;
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
    public partial class AddUserForm : Office2007Form
    {
        public AddUserForm()
        {
            InitializeComponent();

            cbxUserRole.Items.Add(Resources.CommonUser);
            cbxUserRole.Items.Add(Resources.AdminUser);
            cbxUserRole.SelectedIndex = 0;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string user = textBoxUserName.Text;
            user = user.Trim();
            //UserGroup group = Program.SysConfig.UserConfig.RootUserGroup;
            if (Program.SysConfig.UserConfig.AddUser(user, textBoxPassword1.Text, textBoxPassword2.Text, (EmbryoExpress.SysClass.User.UserRoleType)cbxUserRole.SelectedIndex))
            {
                MessageBox.Show(user + Resources.StrAddUserSuccess, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
