namespace toyproject
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            TxtUesrId = new TextBox();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "유저아이디";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "패스워드";
            // 
            // TxtUesrId
            // 
            TxtUesrId.Location = new Point(119, 22);
            TxtUesrId.Name = "TxtUesrId";
            TxtUesrId.Size = new Size(100, 23);
            TxtUesrId.TabIndex = 2;
            TxtUesrId.KeyPress += TxtUesrId_KeyPress;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(119, 59);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(100, 23);
            TxtPassword.TabIndex = 3;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(45, 99);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 30);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "로그인";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(159, 99);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 30);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 141);
            ControlBox = false;
            Controls.Add(BtnCancel);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUesrId);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtUesrId;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private Button BtnCancel;
    }
}