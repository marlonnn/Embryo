using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmbryoExpress.UI
{
    /// <summary>
    /// the base class of plot form
    /// </summary>
    public class ChildForm : DevComponents.DotNetBar.Office2007Form
    {
        // this class is originally for solve the problem that right click inside a form can not activate it
        // however after change the base class from Form to Office2007Form, this problem disappear,
        // so the following codes are commented out, but keep for further reference        

        protected const int WM_SETFOCUS = 0x7;
        protected const int WM_SYSCOMMAND = 0x112;
        protected const int WM_PARENTNOTIFY = 0x0210;
        protected const int WM_LBUTTONDOWN = 0x201;
        protected const int WM_RBUTTONDOWN = 0x204;
        protected const int SC_CLOSE = 0xF060;
        protected const int SC_MINIMIZE = 0xF020;
        protected const int SC_RESTORE = 0xF120;
        protected const int SC_MAXIMIZE = 0xF030;
        protected const int WM_NCPAINT = 0x0085;
        protected const int WM_MDIACTIVATE = 0x0222;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ChildForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChildForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }
        
    }
}
