namespace toyproject
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
            splitContainer1 = new SplitContainer();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            LblLoginId = new ToolStripStatusLabel();
            DgvResult = new DataGridView();
            BtnNew = new Button();
            BtnDel = new Button();
            BtnSave = new Button();
            groupBox2 = new GroupBox();
            TxtAvg = new TextBox();
            TxtTotal = new TextBox();
            BtnSum = new Button();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            NudMath = new NumericUpDown();
            NudEng = new NumericUpDown();
            NudKor = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            TxtstudentName = new TextBox();
            TxtstudentIdx = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvResult).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudMath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudEng).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudKor).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(statusStrip1);
            splitContainer1.Panel1.Controls.Add(DgvResult);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(BtnNew);
            splitContainer1.Panel2.Controls.Add(BtnDel);
            splitContainer1.Panel2.Controls.Add(BtnSave);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(911, 351);
            splitContainer1.SplitterDistance = 610;
            splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, LblLoginId });
            statusStrip1.Location = new Point(0, 329);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(610, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(79, 17);
            toolStripStatusLabel1.Text = "로그인아이디";
            // 
            // LblLoginId
            // 
            LblLoginId.Name = "LblLoginId";
            LblLoginId.Size = new Size(12, 17);
            LblLoginId.Text = "-";
            // 
            // DgvResult
            // 
            DgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvResult.Dock = DockStyle.Fill;
            DgvResult.Location = new Point(0, 0);
            DgvResult.Name = "DgvResult";
            DgvResult.Size = new Size(610, 351);
            DgvResult.TabIndex = 0;
            DgvResult.CellClick += DgvResult_CellClick;
            // 
            // BtnNew
            // 
            BtnNew.Location = new Point(47, 178);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(75, 23);
            BtnNew.TabIndex = 6;
            BtnNew.Text = "신규";
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnDel
            // 
            BtnDel.Location = new Point(209, 178);
            BtnDel.Name = "BtnDel";
            BtnDel.Size = new Size(75, 23);
            BtnDel.TabIndex = 8;
            BtnDel.Text = "삭제";
            BtnDel.UseVisualStyleBackColor = true;
            BtnDel.Click += BtnDel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(128, 177);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 25);
            BtnSave.TabIndex = 7;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtAvg);
            groupBox2.Controls.Add(TxtTotal);
            groupBox2.Controls.Add(BtnSum);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(3, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 130);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "결과";
            // 
            // TxtAvg
            // 
            TxtAvg.Location = new Point(109, 60);
            TxtAvg.Name = "TxtAvg";
            TxtAvg.ReadOnly = true;
            TxtAvg.Size = new Size(100, 23);
            TxtAvg.TabIndex = 10;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(109, 31);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(100, 23);
            TxtTotal.TabIndex = 9;
            // 
            // BtnSum
            // 
            BtnSum.Location = new Point(109, 96);
            BtnSum.Name = "BtnSum";
            BtnSum.Size = new Size(75, 25);
            BtnSum.TabIndex = 11;
            BtnSum.Text = "계산";
            BtnSum.UseVisualStyleBackColor = true;
            BtnSum.Click += BtnSum_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 63);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 1;
            label7.Text = "평균";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 34);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "총점";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NudMath);
            groupBox1.Controls.Add(NudEng);
            groupBox1.Controls.Add(NudKor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtstudentName);
            groupBox1.Controls.Add(TxtstudentIdx);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "성적입력";
            // 
            // NudMath
            // 
            NudMath.Location = new Point(109, 136);
            NudMath.Name = "NudMath";
            NudMath.Size = new Size(100, 23);
            NudMath.TabIndex = 5;
            // 
            // NudEng
            // 
            NudEng.Location = new Point(109, 108);
            NudEng.Name = "NudEng";
            NudEng.Size = new Size(100, 23);
            NudEng.TabIndex = 4;
            // 
            // NudKor
            // 
            NudKor.Location = new Point(109, 80);
            NudKor.Name = "NudKor";
            NudKor.Size = new Size(100, 23);
            NudKor.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 54);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "이름";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 25);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 5;
            label4.Text = "학생번호";
            // 
            // TxtstudentName
            // 
            TxtstudentName.Location = new Point(109, 51);
            TxtstudentName.Name = "TxtstudentName";
            TxtstudentName.Size = new Size(100, 23);
            TxtstudentName.TabIndex = 2;
            // 
            // TxtstudentIdx
            // 
            TxtstudentIdx.Location = new Point(109, 22);
            TxtstudentIdx.Name = "TxtstudentIdx";
            TxtstudentIdx.ReadOnly = true;
            TxtstudentIdx.Size = new Size(100, 23);
            TxtstudentIdx.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 138);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "수학";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 110);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "영어";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 80);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "국어";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 351);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "성적계산기";
            Load += FrmMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvResult).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudMath).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudEng).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudKor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private DataGridView DgvResult;
        private StatusStrip statusStrip1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox TxtTotal;
        private Label label7;
        private Label label6;
        private Button BtnSum;
        private TextBox TxtAvg;
        private Label label5;
        private Label label4;
        private TextBox TxtstudentName;
        private TextBox TxtstudentIdx;
        private Button BtnSave;
        private Button BtnNew;
        private Button BtnDel;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel LblLoginId;
        private NumericUpDown NudMath;
        private NumericUpDown NudEng;
        private NumericUpDown NudKor;
    }
}
