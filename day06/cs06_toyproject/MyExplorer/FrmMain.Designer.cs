namespace MyExplorer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            BtnOpen = new Button();
            TxtPath = new TextBox();
            label1 = new Label();
            SpcExplorer = new SplitContainer();
            TrvFolder = new TreeView();
            ImgSmallicon = new ImageList(components);
            LsvFile = new ListView();
            ClhTitle = new ColumnHeader();
            ClhModifiedData = new ColumnHeader();
            ClhType = new ColumnHeader();
            ClhSize = new ColumnHeader();
            ImgLargeicon = new ImageList(components);
            CmsFiles = new ContextMenuStrip(components);
            보기ToolStripMenuItem = new ToolStripMenuItem();
            큰아이콘ToolStripMenuItem = new ToolStripMenuItem();
            작은아이콘ToolStripMenuItem = new ToolStripMenuItem();
            목록ToolStripMenuItem = new ToolStripMenuItem();
            자세히ToolStripMenuItem = new ToolStripMenuItem();
            타일ToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpcExplorer).BeginInit();
            SpcExplorer.Panel1.SuspendLayout();
            SpcExplorer.Panel2.SuspendLayout();
            SpcExplorer.SuspendLayout();
            CmsFiles.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(BtnOpen);
            panel1.Controls.Add(TxtPath);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 46);
            panel1.TabIndex = 0;
            // 
            // BtnOpen
            // 
            BtnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnOpen.Location = new Point(876, 10);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(61, 23);
            BtnOpen.TabIndex = 2;
            BtnOpen.Text = "열기";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // TxtPath
            // 
            TxtPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPath.Location = new Point(49, 11);
            TxtPath.Name = "TxtPath";
            TxtPath.ReadOnly = true;
            TxtPath.Size = new Size(821, 23);
            TxtPath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "경로";
            // 
            // SpcExplorer
            // 
            SpcExplorer.Dock = DockStyle.Fill;
            SpcExplorer.Location = new Point(0, 46);
            SpcExplorer.Name = "SpcExplorer";
            // 
            // SpcExplorer.Panel1
            // 
            SpcExplorer.Panel1.Controls.Add(TrvFolder);
            // 
            // SpcExplorer.Panel2
            // 
            SpcExplorer.Panel2.Controls.Add(LsvFile);
            SpcExplorer.Size = new Size(949, 404);
            SpcExplorer.SplitterDistance = 316;
            SpcExplorer.TabIndex = 1;
            // 
            // TrvFolder
            // 
            TrvFolder.BorderStyle = BorderStyle.None;
            TrvFolder.Dock = DockStyle.Fill;
            TrvFolder.ImageIndex = 0;
            TrvFolder.ImageList = ImgSmallicon;
            TrvFolder.Location = new Point(0, 0);
            TrvFolder.Name = "TrvFolder";
            TrvFolder.SelectedImageIndex = 0;
            TrvFolder.Size = new Size(316, 404);
            TrvFolder.TabIndex = 0;
            TrvFolder.BeforeExpand += TrvFolder_BeforeExpand;
            TrvFolder.AfterSelect += TrvFolder_AfterSelect;
            // 
            // ImgSmallicon
            // 
            ImgSmallicon.ColorDepth = ColorDepth.Depth32Bit;
            ImgSmallicon.ImageStream = (ImageListStreamer)resources.GetObject("ImgSmallicon.ImageStream");
            ImgSmallicon.TransparentColor = Color.Transparent;
            ImgSmallicon.Images.SetKeyName(0, "hard-drive.png");
            ImgSmallicon.Images.SetKeyName(1, "folder-normal.png");
            ImgSmallicon.Images.SetKeyName(2, "folder-open.png");
            ImgSmallicon.Images.SetKeyName(3, "file-exe.png");
            ImgSmallicon.Images.SetKeyName(4, "file-normal.png");
            ImgSmallicon.Images.SetKeyName(5, "txt.png");
            // 
            // LsvFile
            // 
            LsvFile.BorderStyle = BorderStyle.None;
            LsvFile.Columns.AddRange(new ColumnHeader[] { ClhTitle, ClhModifiedData, ClhType, ClhSize });
            LsvFile.Dock = DockStyle.Fill;
            LsvFile.LargeImageList = ImgLargeicon;
            LsvFile.Location = new Point(0, 0);
            LsvFile.Name = "LsvFile";
            LsvFile.Size = new Size(629, 404);
            LsvFile.SmallImageList = ImgSmallicon;
            LsvFile.TabIndex = 0;
            LsvFile.UseCompatibleStateImageBehavior = false;
            LsvFile.View = View.Details;
            LsvFile.MouseDown += LsvFile_MouseDown;
            // 
            // ClhTitle
            // 
            ClhTitle.Text = "이름";
            ClhTitle.Width = 200;
            // 
            // ClhModifiedData
            // 
            ClhModifiedData.Text = "수정일자";
            ClhModifiedData.Width = 100;
            // 
            // ClhType
            // 
            ClhType.Text = "유형";
            ClhType.Width = 100;
            // 
            // ClhSize
            // 
            ClhSize.Text = "크기";
            ClhSize.TextAlign = HorizontalAlignment.Right;
            ClhSize.Width = 150;
            // 
            // ImgLargeicon
            // 
            ImgLargeicon.ColorDepth = ColorDepth.Depth32Bit;
            ImgLargeicon.ImageStream = (ImageListStreamer)resources.GetObject("ImgLargeicon.ImageStream");
            ImgLargeicon.TransparentColor = Color.Transparent;
            ImgLargeicon.Images.SetKeyName(0, "hard-drive.png");
            ImgLargeicon.Images.SetKeyName(1, "folder-normal.png");
            ImgLargeicon.Images.SetKeyName(2, "folder-open.png");
            ImgLargeicon.Images.SetKeyName(3, "file-exe.png");
            ImgLargeicon.Images.SetKeyName(4, "file-normal.png");
            ImgLargeicon.Images.SetKeyName(5, "txt.png");
            // 
            // CmsFiles
            // 
            CmsFiles.Items.AddRange(new ToolStripItem[] { 보기ToolStripMenuItem });
            CmsFiles.Name = "CmsFiles";
            CmsFiles.Size = new Size(99, 26);
            // 
            // 보기ToolStripMenuItem
            // 
            보기ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 큰아이콘ToolStripMenuItem, 작은아이콘ToolStripMenuItem, 목록ToolStripMenuItem, 자세히ToolStripMenuItem, 타일ToolStripMenuItem });
            보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            보기ToolStripMenuItem.Size = new Size(98, 22);
            보기ToolStripMenuItem.Text = "보기";
            // 
            // 큰아이콘ToolStripMenuItem
            // 
            큰아이콘ToolStripMenuItem.Name = "큰아이콘ToolStripMenuItem";
            큰아이콘ToolStripMenuItem.Size = new Size(138, 22);
            큰아이콘ToolStripMenuItem.Text = "큰 아이콘";
            // 
            // 작은아이콘ToolStripMenuItem
            // 
            작은아이콘ToolStripMenuItem.Name = "작은아이콘ToolStripMenuItem";
            작은아이콘ToolStripMenuItem.Size = new Size(138, 22);
            작은아이콘ToolStripMenuItem.Text = "작은 아이콘";
            // 
            // 목록ToolStripMenuItem
            // 
            목록ToolStripMenuItem.Name = "목록ToolStripMenuItem";
            목록ToolStripMenuItem.Size = new Size(138, 22);
            목록ToolStripMenuItem.Text = "목록";
            // 
            // 자세히ToolStripMenuItem
            // 
            자세히ToolStripMenuItem.Name = "자세히ToolStripMenuItem";
            자세히ToolStripMenuItem.Size = new Size(138, 22);
            자세히ToolStripMenuItem.Text = "자세히";
            // 
            // 타일ToolStripMenuItem
            // 
            타일ToolStripMenuItem.Name = "타일ToolStripMenuItem";
            타일ToolStripMenuItem.Size = new Size(138, 22);
            타일ToolStripMenuItem.Text = "타일";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 450);
            Controls.Add(SpcExplorer);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "내 탐색기 v1.0";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SpcExplorer.Panel1.ResumeLayout(false);
            SpcExplorer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpcExplorer).EndInit();
            SpcExplorer.ResumeLayout(false);
            CmsFiles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnOpen;
        private TextBox TxtPath;
        private Label label1;
        private SplitContainer SpcExplorer;
        private TreeView TrvFolder;
        private ListView LsvFile;
        private ColumnHeader ClhTitle;
        private ColumnHeader ClhSize;
        private ColumnHeader ClhType;
        private ColumnHeader ClhModifiedData;
        private ImageList ImgSmallicon;
        private ImageList ImgLargeicon;
        private ContextMenuStrip CmsFiles;
        private ToolStripMenuItem 보기ToolStripMenuItem;
        private ToolStripMenuItem 큰아이콘ToolStripMenuItem;
        private ToolStripMenuItem 작은아이콘ToolStripMenuItem;
        private ToolStripMenuItem 목록ToolStripMenuItem;
        private ToolStripMenuItem 자세히ToolStripMenuItem;
        private ToolStripMenuItem 타일ToolStripMenuItem;
    }
}
