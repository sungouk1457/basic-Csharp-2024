using System.ComponentModel;
using System.Threading; //������ Ŭ���� �����

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

            //GrbEditor.Text = "�ؽ��Ϳ�����"; // �ڵ�����ε� �����μ���
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
            FrmModal.StartPosition = FormStartPosition.CenterParent;
            FrmModal.ShowDialog();//���â ����
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form FrmModaless = new Form();
            FrmModaless.Text = "��޸���â";
            FrmModaless.Width = 300;
            FrmModaless.Height = 100;
            FrmModaless.BackColor = Color.Green;
            FrmModaless.StartPosition = FormStartPosition.Manual;
            FrmModaless.Location = new Point(this.Location.X + (this.Width - FrmModaless.Width) / 2,
                                             this.Location.Y + (this.Height - FrmModaless.Height) / 2);
            FrmModaless.Show(this);//��޸���â ����
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
            if (PicNormal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PicNormal.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        //�Ϲ��ؽ�Ʈ ���� �ε� �̺�Ʈ�ڵ鷯
        private void BtnFileLoad_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ��Ʈ���� �����ο��� �������� �ʰ� �����ϴ� ���
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; //������ ���� ������ ����
            dialog.Filter = "Text Files(*.txt;*.cs;*.py)|*.txt;*.cs;*.py";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //UTF-8�� �ѱ��� ����. EUC-KR(Window 949), UTF-8(BOM)�� �ѱ��� ���� ����
                RtxEditor.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        //��ü�ؽ�Ʈ ���� ���� �̺�Ʈ�ڵ鷯
        private void BtnFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "RichText Files(*.rtf)|*.rtf";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                RtxEditor.SaveFile(dialog.FileName, RichTextBoxStreamType.RichNoOleObjs);
            }
        }

        private void BtnNothread_Click(object sender, EventArgs e)
        {
            //���α׷����� ����
            var maxValue = 100;
            var currValue = 0;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = maxValue;
            PrgProcess.Value = 0; //0���� �ʱ�ȭ
            BtnThread.Enabled = false;
            BtnNothread.Enabled = false;
            BtnStop.Enabled = true;

            //�ݺ�����
            for (var i = 0; i <= maxValue; i++)
            {
                // ���������� �����ϰ� �ð��� ���� ���ϴ� �۾�
                currValue = i;
                PrgProcess.Value = currValue;
                TxtLog.AppendText($"�������� : {currValue}\r\n");
                Thread.Sleep(500); //1000ms = 1��
            }
            BtnThread.Enabled = BtnNothread.Enabled = true;
            BtnStop.Enabled = false;
        }

        private void BtnThread_Click(object sender, EventArgs e)
        {
            var maxValue = 100;
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = maxValue;
            PrgProcess.Value = 0; //0���� �ʱ�ȭ

            BtnThread.Enabled = BtnNothread.Enabled = false;
            BtnStop.Enabled = true ;

            BgwProgress.WorkerReportsProgress = true; //������� ����Ʈ Ȱ��ȭ
            BgwProgress.WorkerSupportsCancellation = true; //��׶����Ŀ ��� Ȱ��ȭ
            BgwProgress.RunWorkerAsync(null); //��׶����Ŀ ����
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BgwProgress.CancelAsync();//�񵿱�� ��ҽ���
        }
        #region '��׶����Ŀ �̺�Ʈ�ڵ鷯'
        private void DoRealWork(BackgroundWorker worker, DoWorkEventArgs e)
        {
            var maxValue = 100;
            double currValue = 0; //�Ǽ������� ����

            for(var i = 0;i <= maxValue;i++)
            {
                if (worker.CancellationPending) //�߰��� ����Ұ��� ����� ��
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    currValue = i;
                    //�����ð��� �ɸ��� ��ó��
                    Thread.Sleep(500);

                    // �Ʒ��� �����ϸ�, BgwProgress_ProcessChaged �̺�Ʈ�ڵ鷯��
                    // ProgressChangedEventArgs���� ProgressPercentage �Ӽ��� ���� ��
                    worker.ReportProgress((int)((currValue / maxValue) * 100));
                }
            }
        }

        //���� ����
        private void BgwProgress_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DoRealWork((BackgroundWorker)sender, e);
            e.Result = null;
        }

        //������� �ٲ�� �� ǥ��
        private void BgwProgress_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            PrgProcess.Value = e.ProgressPercentage;
            TxtLog.AppendText($"����� : {PrgProcess.Value}%\r\n");
        }

        //������ �Ϸ�Ǹ� �� ���� ó��
        private void BgwProgress_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                TxtLog.AppendText("�۾��� ��ҵǾ����ϴ�.\r\n");
            }
            else
            {
                TxtLog.AppendText("�۾��� �Ϸ�Ǿ����ϴ�.\r\n");
            }
            BtnNothread.Enabled = BtnThread.Enabled = true;
            BtnStop.Enabled = false;
        }
        #endregion
    }
}