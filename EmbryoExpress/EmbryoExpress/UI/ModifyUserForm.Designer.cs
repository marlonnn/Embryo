namespace EmbryoExpress.UI
{
    partial class ModifyUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUserForm));
            this.labelUser = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbxUserRole = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxUserNameInPut = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonChange = new DevComponents.DotNetBar.ButtonX();
            this.buttonCancel = new DevComponents.DotNetBar.ButtonX();
            this.textBoxPassword2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxNewPassword1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxOldPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            // 
            // 
            // 
            this.labelUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelUser, "labelUser");
            this.labelUser.Name = "labelUser";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.Name = "labelX4";
            // 
            // cbxUserRole
            // 
            this.cbxUserRole.DisplayMember = "Text";
            this.cbxUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserRole.FormattingEnabled = true;
            resources.ApplyResources(this.cbxUserRole, "cbxUserRole");
            this.cbxUserRole.Name = "cbxUserRole";
            this.cbxUserRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxUserRole.SelectedIndexChanged += new System.EventHandler(this.cbxUserRole_SelectedIndexChanged);
            // 
            // textBoxUserNameInPut
            // 
            // 
            // 
            // 
            this.textBoxUserNameInPut.Border.Class = "TextBoxBorder";
            this.textBoxUserNameInPut.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.textBoxUserNameInPut, "textBoxUserNameInPut");
            this.textBoxUserNameInPut.Name = "textBoxUserNameInPut";
            this.textBoxUserNameInPut.TextChanged += new System.EventHandler(this.userName_Changed);
            // 
            // buttonChange
            // 
            this.buttonChange.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonChange.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.buttonChange, "buttonChange");
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // textBoxPassword2
            // 
            // 
            // 
            // 
            this.textBoxPassword2.Border.Class = "TextBoxBorder";
            this.textBoxPassword2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.textBoxPassword2, "textBoxPassword2");
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Enter += new System.EventHandler(this.newPassword2_Enter);
            // 
            // textBoxNewPassword1
            // 
            // 
            // 
            // 
            this.textBoxNewPassword1.Border.Class = "TextBoxBorder";
            this.textBoxNewPassword1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.textBoxNewPassword1, "textBoxNewPassword1");
            this.textBoxNewPassword1.Name = "textBoxNewPassword1";
            this.textBoxNewPassword1.Enter += new System.EventHandler(this.newPassword1_Enter);
            // 
            // textBoxOldPassword
            // 
            // 
            // 
            // 
            this.textBoxOldPassword.Border.Class = "TextBoxBorder";
            this.textBoxOldPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.textBoxOldPassword, "textBoxOldPassword");
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Enter += new System.EventHandler(this.OldPassword_Enter);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.Name = "labelX3";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.Name = "labelX2";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            // 
            // ModifyUserForm
            // 
            this.AcceptButton = this.buttonChange;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cbxUserRole);
            this.Controls.Add(this.textBoxUserNameInPut);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.textBoxNewPassword1);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "ModifyUserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelUser;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxUserRole;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxUserNameInPut;
        private DevComponents.DotNetBar.ButtonX buttonChange;
        private DevComponents.DotNetBar.ButtonX buttonCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPassword2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxNewPassword1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxOldPassword;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}