namespace ex18_winControlApp
{
    public partial class FrmMain : Form
    {
        Random rand = new Random(); // Ʈ���� ����̸����� ����� ������
        public FrmMain()
        {
            InitializeComponent(); //�����̳ʿ��� ������ ȭ�鱸�� �ʱ�ȭ

            LsvDummy.Columns.Add("�̸�");
            LsvDummy.Columns.Add("����");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // ���� OS���� ��ġ�� ��Ʈ�� �ٰ�����
            foreach (var font in Fonts)
            {
                CboFonts.Items.Add(font.Name);
            }
        }
        // ����ü,����,���Ÿ����� �����ϴ� �޼���
        void changeFont()
        {
            if (CboFonts.SelectedIndex < 0) //�ƹ��͵� ���þȵ�
                return;

            FontStyle style = FontStyle.Regular; //�Ϲݱ���(����X, ���Ÿ�X)

            if (ChkBold.Checked)  //���� üũ�ڽ��� üũ�ϸ�
                style |= FontStyle.Bold;
            if (ChkItalic.Checked)
                style |= FontStyle.Italic;

            TxtSampleText.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            //throw new NotImplementedException();
            LsvDummy.Items.Add( //����Ʈ�信 ������ �߰�
                new ListViewItem(
                    new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }
                    )
                );
            foreach (TreeNode subnode in node.Nodes)
            {
                TreeToList(subnode);
            }
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        //Ʈ���� ��ũ�� �̺�Ʈ�ڵ鷯
        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PrgDummy.Value = TrbDummy.Value; //Ʈ���� �����͸� �ű�� ���α׷����� ���� ���� ����
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form FrmModal = new Form();
            FrmModal.Text = "���â";
            FrmModal.Width = 300;
            FrmModal.Height = 100;
            FrmModal.BackColor = Color.Red;
            FrmModal.ShowDialog();//���â ����
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form FrmModaless = new Form();
            FrmModaless.Text = "��޸���â";
            FrmModaless.Width = 300;
            FrmModaless.Height = 100;
            FrmModaless.BackColor = Color.Green;
            FrmModaless.Show();//���â ����
        }

        private void BtnMsgbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtSampleText.Text, "�޽����ڽ�", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("���ƿ�?", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("�� ���ƿ�");
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("�ƴ� ���� �Ⱦ��");
            }
        }

        // ������ �����ư�� Ŭ�������� �߻��ϴ� �̺�Ʈ�ڵ鷯
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("���� �����Ͻðڽ��ϱ�?", "���Ῡ��",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                e.Cancel = true;
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(rand.Next().ToString());
            TreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null) //�θ��带 �������� ������
            {
                MessageBox.Show("������ ��尡 ����", "���", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //���̻� ������� �޼��� ����
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand();
            TreeToList(); //����Ʈ�並 �ٽ� �׷��ش�
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "�̹��� ����";
            // Filter�� Ȯ���ڸ� �̹����θ� ����
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            var res = DlgOpenImage.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                //MessageBox.Show(DlgOpenImage.FileName.ToString());
                PicNormal.Image = Bitmap.FromFile(DlgOpenImage.FileName);
            }
        }

        private void PicNormal_Click(object sender, EventArgs e)
        {
            if(PicNormal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PicNormal.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}