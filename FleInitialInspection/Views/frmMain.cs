using FleInitialInspection.Views;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FleInitialInspection
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region  Move Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void picManimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("ปิดโปรแกรม ?", "การยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.Cancel)
            {
                return;
            }

            Application.Exit();
        }

        private void lblProgramName_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion  Move Form

        bool isBarBig = false;

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;
            lblProgramName.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;
            lblProgramNameTopBar.Text = Properties.Settings.Default.SOFTWARE_NUMBER + " " + Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;
            lblFooter.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION + " © 2020 Furukawa Fitel(Thailand) All rights reserved";

            loadMenuRecord(null, null);
            pnlMenu.Size = new System.Drawing.Size(51, 929);
        }

        void loadMenuRecord(object sender, EventArgs e)
        {
            lblProgramName.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;

            this.pnlBody.Controls.Clear();
            pageRecord page = new pageRecord();
            page.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(page);
        }

        void loadMenuSearch(object sender, EventArgs e)
        {
            lblProgramName.Text = Properties.Settings.Default.PROGRAM_NAME + " " + Properties.Settings.Default.PROGRAM_VERSION;

            this.pnlBody.Controls.Clear();
            pageSearch page = new pageSearch();
            page.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(page);
        }

        private void picBar_Click(object sender, EventArgs e)
        {
            if (isBarBig)
            {
                pnlMenu.Size = new System.Drawing.Size(51, 929);
                isBarBig = false;
                pnlMenuButton.Visible = false;
                pnlpicBar.Visible = true;
            }
            else
            {
                pnlMenu.Size = new System.Drawing.Size(141, 929);
                isBarBig = true;
                pnlMenuButton.Visible = true;
                pnlpicBar.Visible = false;
            }
        }
    }
}
