﻿namespace BookRentalShopApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            MnsBookRantal = new MenuStrip();
            StsBookRental = new StatusStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            MnsBookRantal.SuspendLayout();
            StsBookRental.SuspendLayout();
            SuspendLayout();
            // 
            // MnsBookRantal
            // 
            MnsBookRantal.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            MnsBookRantal.Location = new Point(0, 0);
            MnsBookRantal.Name = "MnsBookRantal";
            MnsBookRantal.Size = new Size(765, 24);
            MnsBookRantal.TabIndex = 1;
            MnsBookRantal.Text = "menuStrip1";
            // 
            // StsBookRental
            // 
            StsBookRental.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            StsBookRental.Location = new Point(0, 456);
            StsBookRental.Name = "StsBookRental";
            StsBookRental.Size = new Size(765, 22);
            StsBookRental.TabIndex = 2;
            StsBookRental.Text = "statusStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 20);
            toolStripMenuItem1.Text = "파일(&F)";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(62, 20);
            toolStripMenuItem2.Text = "관리(&M)";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(72, 20);
            toolStripMenuItem3.Text = "도움말(&H)";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(83, 17);
            toolStripStatusLabel1.Text = "로그인 아이디";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(40, 17);
            toolStripStatusLabel2.Text = "UserId";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(109, 17);
            toolStripStatusLabel3.Text = "LastLoginDateTime";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 478);
            Controls.Add(StsBookRental);
            Controls.Add(MnsBookRantal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MnsBookRantal;
            Name = "FrmMain";
            Text = "책 대여점 v1.1";
            Load += FrmMain_Load;
            MnsBookRantal.ResumeLayout(false);
            MnsBookRantal.PerformLayout();
            StsBookRental.ResumeLayout(false);
            StsBookRental.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MnsBookRantal;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private StatusStrip StsBookRental;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}
