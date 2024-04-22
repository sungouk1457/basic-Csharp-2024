namespace NewBookRentalShopApp
{
    partial class FrmLoginUser
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.Txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.Txtuserid = new MetroFramework.Controls.MetroTextBox();
            this.TxtuserIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DgvResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(727, 333);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 0;
            // 
            // DgvResult
            // 
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResult.Location = new System.Drawing.Point(0, 0);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 23;
            this.DgvResult.Size = new System.Drawing.Size(363, 333);
            this.DgvResult.TabIndex = 0;
            this.DgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResult_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.Txtpassword);
            this.groupBox1.Controls.Add(this.Txtuserid);
            this.groupBox1.Controls.Add(this.TxtuserIdx);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로그인사용자 입력항목";
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(270, 142);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(70, 30);
            this.BtnDel.TabIndex = 8;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(194, 142);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 30);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(117, 142);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(70, 30);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Txtpassword
            // 
            // 
            // 
            // 
            this.Txtpassword.CustomButton.Image = null;
            this.Txtpassword.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.Txtpassword.CustomButton.Name = "";
            this.Txtpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txtpassword.CustomButton.TabIndex = 1;
            this.Txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txtpassword.CustomButton.UseSelectable = true;
            this.Txtpassword.CustomButton.Visible = false;
            this.Txtpassword.Lines = new string[0];
            this.Txtpassword.Location = new System.Drawing.Point(117, 99);
            this.Txtpassword.MaxLength = 32767;
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.PasswordChar = '●';
            this.Txtpassword.PromptText = "패스워드 입력";
            this.Txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txtpassword.SelectedText = "";
            this.Txtpassword.SelectionLength = 0;
            this.Txtpassword.SelectionStart = 0;
            this.Txtpassword.ShortcutsEnabled = true;
            this.Txtpassword.Size = new System.Drawing.Size(193, 23);
            this.Txtpassword.TabIndex = 5;
            this.Txtpassword.UseSelectable = true;
            this.Txtpassword.WaterMark = "패스워드 입력";
            this.Txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txtpassword.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Txtuserid
            // 
            // 
            // 
            // 
            this.Txtuserid.CustomButton.Image = null;
            this.Txtuserid.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.Txtuserid.CustomButton.Name = "";
            this.Txtuserid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txtuserid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txtuserid.CustomButton.TabIndex = 1;
            this.Txtuserid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txtuserid.CustomButton.UseSelectable = true;
            this.Txtuserid.CustomButton.Visible = false;
            this.Txtuserid.Lines = new string[0];
            this.Txtuserid.Location = new System.Drawing.Point(117, 70);
            this.Txtuserid.MaxLength = 32767;
            this.Txtuserid.Name = "Txtuserid";
            this.Txtuserid.PasswordChar = '\0';
            this.Txtuserid.PromptText = "사용자아이디 입력";
            this.Txtuserid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txtuserid.SelectedText = "";
            this.Txtuserid.SelectionLength = 0;
            this.Txtuserid.SelectionStart = 0;
            this.Txtuserid.ShortcutsEnabled = true;
            this.Txtuserid.Size = new System.Drawing.Size(193, 23);
            this.Txtuserid.TabIndex = 4;
            this.Txtuserid.UseSelectable = true;
            this.Txtuserid.WaterMark = "사용자아이디 입력";
            this.Txtuserid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txtuserid.WaterMarkFont = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtuserIdx
            // 
            // 
            // 
            // 
            this.TxtuserIdx.CustomButton.Image = null;
            this.TxtuserIdx.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.TxtuserIdx.CustomButton.Name = "";
            this.TxtuserIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtuserIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtuserIdx.CustomButton.TabIndex = 1;
            this.TxtuserIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtuserIdx.CustomButton.UseSelectable = true;
            this.TxtuserIdx.CustomButton.Visible = false;
            this.TxtuserIdx.Lines = new string[0];
            this.TxtuserIdx.Location = new System.Drawing.Point(117, 41);
            this.TxtuserIdx.MaxLength = 32767;
            this.TxtuserIdx.Name = "TxtuserIdx";
            this.TxtuserIdx.PasswordChar = '\0';
            this.TxtuserIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtuserIdx.SelectedText = "";
            this.TxtuserIdx.SelectionLength = 0;
            this.TxtuserIdx.SelectionStart = 0;
            this.TxtuserIdx.ShortcutsEnabled = true;
            this.TxtuserIdx.Size = new System.Drawing.Size(193, 23);
            this.TxtuserIdx.TabIndex = 3;
            this.TxtuserIdx.UseSelectable = true;
            this.TxtuserIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtuserIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "패스워드";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "사용자아이디";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "사용자순번";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 413);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmLoginUser";
            this.Text = "로그인사용자";
            this.Load += new System.EventHandler(this.FrmLoginUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TxtuserIdx;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnDel;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox Txtpassword;
        private MetroFramework.Controls.MetroTextBox Txtuserid;
    }
}