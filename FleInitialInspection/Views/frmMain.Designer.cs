namespace FleInitialInspection
{
    partial class frmMain
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblProgramNameTopBar = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picManimise = new System.Windows.Forms.PictureBox();
            this.footer = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.bgwReworkProduct = new System.ComponentModel.BackgroundWorker();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlpicBar = new System.Windows.Forms.Panel();
            this.picBar = new System.Windows.Forms.PictureBox();
            this.pnlMenuButton = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManimise)).BeginInit();
            this.footer.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlpicBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).BeginInit();
            this.pnlMenuButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.panel5.Controls.Add(this.lblProgramNameTopBar);
            this.panel5.Controls.Add(this.picClose);
            this.panel5.Controls.Add(this.picManimise);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1264, 33);
            this.panel5.TabIndex = 10;
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblProgramName_MouseMove);
            // 
            // lblProgramNameTopBar
            // 
            this.lblProgramNameTopBar.AutoSize = true;
            this.lblProgramNameTopBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProgramNameTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProgramNameTopBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramNameTopBar.ForeColor = System.Drawing.Color.White;
            this.lblProgramNameTopBar.Location = new System.Drawing.Point(0, 0);
            this.lblProgramNameTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.lblProgramNameTopBar.Name = "lblProgramNameTopBar";
            this.lblProgramNameTopBar.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblProgramNameTopBar.Size = new System.Drawing.Size(51, 26);
            this.lblProgramNameTopBar.TabIndex = 695;
            this.lblProgramNameTopBar.Text = "XXXX";
            this.lblProgramNameTopBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::FleInitialInspection.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(1237, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 693;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picManimise
            // 
            this.picManimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picManimise.BackColor = System.Drawing.Color.Transparent;
            this.picManimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picManimise.Image = global::FleInitialInspection.Properties.Resources.minus;
            this.picManimise.Location = new System.Drawing.Point(1205, 5);
            this.picManimise.Name = "picManimise";
            this.picManimise.Size = new System.Drawing.Size(20, 20);
            this.picManimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManimise.TabIndex = 694;
            this.picManimise.TabStop = false;
            this.picManimise.Click += new System.EventHandler(this.picManimise_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.footer.Controls.Add(this.lblFooter);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 962);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1264, 23);
            this.footer.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.lblFooter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFooter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(0, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1264, 23);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "XXX";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bgwReworkProduct
            // 
            this.bgwReworkProduct.WorkerReportsProgress = true;
            this.bgwReworkProduct.WorkerSupportsCancellation = true;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(141, 86);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1123, 876);
            this.pnlBody.TabIndex = 12;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.lblProgramName);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.footer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1264, 985);
            this.pnlMain.TabIndex = 3;
            // 
            // lblProgramName
            // 
            this.lblProgramName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.lblProgramName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblProgramName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProgramName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.ForeColor = System.Drawing.Color.White;
            this.lblProgramName.Location = new System.Drawing.Point(141, 33);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(1123, 53);
            this.lblProgramName.TabIndex = 5;
            this.lblProgramName.Text = "INITIAL INSPECTION PROGRAM";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.pnlMenu.Controls.Add(this.pnlpicBar);
            this.pnlMenu.Controls.Add(this.pnlMenuButton);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 33);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(141, 929);
            this.pnlMenu.TabIndex = 11;
            // 
            // pnlpicBar
            // 
            this.pnlpicBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.pnlpicBar.Controls.Add(this.picBar);
            this.pnlpicBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlpicBar.Location = new System.Drawing.Point(-1, 0);
            this.pnlpicBar.Name = "pnlpicBar";
            this.pnlpicBar.Size = new System.Drawing.Size(142, 53);
            this.pnlpicBar.TabIndex = 10;
            // 
            // picBar
            // 
            this.picBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.picBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBar.Image = global::FleInitialInspection.Properties.Resources.menu;
            this.picBar.Location = new System.Drawing.Point(7, 7);
            this.picBar.Name = "picBar";
            this.picBar.Size = new System.Drawing.Size(43, 38);
            this.picBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBar.TabIndex = 4;
            this.picBar.TabStop = false;
            this.picBar.Click += new System.EventHandler(this.picBar_Click);
            // 
            // pnlMenuButton
            // 
            this.pnlMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.pnlMenuButton.Controls.Add(this.pictureBox3);
            this.pnlMenuButton.Controls.Add(this.label3);
            this.pnlMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMenuButton.Location = new System.Drawing.Point(-1, 0);
            this.pnlMenuButton.Name = "pnlMenuButton";
            this.pnlMenuButton.Size = new System.Drawing.Size(142, 53);
            this.pnlMenuButton.TabIndex = 9;
            this.pnlMenuButton.Visible = false;
            this.pnlMenuButton.Click += new System.EventHandler(this.picBar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::FleInitialInspection.Properties.Resources.menu;
            this.pictureBox3.Location = new System.Drawing.Point(90, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.picBar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu";
            this.label3.Click += new System.EventHandler(this.picBar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 52);
            this.panel2.TabIndex = 8;
            this.panel2.Click += new System.EventHandler(this.loadMenuSearch);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::FleInitialInspection.Properties.Resources.loupe;
            this.pictureBox2.Location = new System.Drawing.Point(5, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.loadMenuSearch);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.loadMenuSearch);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 52);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.loadMenuRecord);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::FleInitialInspection.Properties.Resources.save;
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.loadMenuRecord);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Record";
            this.label1.Click += new System.EventHandler(this.loadMenuRecord);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManimise)).EndInit();
            this.footer.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlpicBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBar)).EndInit();
            this.pnlMenuButton.ResumeLayout(false);
            this.pnlMenuButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProgramNameTopBar;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picManimise;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label lblFooter;
        private System.ComponentModel.BackgroundWorker bgwReworkProduct;
        public System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenuButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlpicBar;
    }
}

