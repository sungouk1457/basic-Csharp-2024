using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace toyproject

{
    public partial class FrmMain : Form
    {
        private bool isNew = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            try
            {
                double score3 = Convert.ToDouble(NudKor.Value);
                double score4 = Convert.ToDouble(NudEng.Value);
                double score5 = Convert.ToDouble(NudMath.Value);

                double totalScore = score3 + score4 + score5;
                double averageScore = totalScore / 3;

                TxtTotal.Text = totalScore.ToString();
                TxtAvg.Text = averageScore.ToString("0.0");
            }
            catch
            {
                MessageBox.Show("������ �ùٸ��� �Է����ּ���.");
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.TopMost = true;
            frm.ShowDialog();

            LblLoginId.Text = Helper.Common.LoginId;
            RefreshData();
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                var query = @"SELECT studentIdx
                                   , studentName
                                   , Kor
                                   , Eng
                                   , Math
                                   , Total
                                   , [Avg]
                                   , Grade
                              FROM studenttbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "studenttbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; //�����Ұ�
                DgvResult.Columns[0].HeaderText = "�л���ȣ";
                DgvResult.Columns[1].HeaderText = "�л��̸�";
                DgvResult.Columns[2].HeaderText = "����";
                DgvResult.Columns[3].HeaderText = "����";
                DgvResult.Columns[4].HeaderText = "����";
                DgvResult.Columns[5].HeaderText = "����";
                DgvResult.Columns[6].HeaderText = "���";
                DgvResult.Columns[7].HeaderText = "���";

                DgvResult.Columns[0].Width = 80;
                DgvResult.Columns[1].Width = 85;
                DgvResult.Columns[2].Width = 60;
                DgvResult.Columns[3].Width = 60;
                DgvResult.Columns[4].Width = 60;
                DgvResult.Columns[5].Width = 80;
                DgvResult.Columns[6].Width = 60;
                DgvResult.Columns[7].Width = 60;
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtTotal.Text = TxtAvg.Text = string.Empty;
            if (e.RowIndex > -1)
            {   
                var selData = DgvResult.Rows[e.RowIndex];
                TxtstudentIdx.Text = selData.Cells[0].Value.ToString();
                TxtstudentName.Text = selData.Cells[1].Value.ToString();
                NudKor.Value = Decimal.Parse(selData.Cells[2].Value.ToString());
                NudEng.Value = Decimal.Parse(selData.Cells[3].Value.ToString());
                NudMath.Value = Decimal.Parse(selData.Cells[4].Value.ToString());
            }
            isNew = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtstudentIdx.Text = TxtstudentName.Text = string.Empty;
            TxtstudentIdx.Focus();
            NudKor.Value = NudEng.Value = NudMath.Value = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtstudentName.Text))
            {
                MessageBox.Show("�л����� �Է��ϼ���");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();
                    var query = "";
                    if (isNew)
                    {
                        query = @"INSERT INTO studenttbl
                                            ( studentName
                                            , Kor
                                            , Eng
                                            , Math
                                            , Total
                                            , Avg
                                            , Grade)
                                       VALUES
                                            ( @studentName
                                             , @Kor
                                             , @Eng
                                             , @Math
                                             , @Total
                                             , @Avg
                                             , @Grade)";
                    }
                    else
                    {
                        query = @"UPDATE studenttbl
                                     SET studentName = @studentName
                                      , Kor = @Kor
                                      , Eng = @Eng
                                      , Math = @Math
                                      , Total = @Total
                                      , [Avg] = @Avg
                                      , Grade = @Grade
                                  WHERE studentIdx = @studentIdx";
                    }
    
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmStudnetName = new SqlParameter("@studentName", TxtstudentName.Text);
                    cmd.Parameters.Add(prmStudnetName);
                    SqlParameter prmKor = new SqlParameter("@Kor", NudKor.Text);
                    cmd.Parameters.Add(prmKor);
                    SqlParameter prmEng = new SqlParameter("@Eng", NudEng.Text);
                    cmd.Parameters.Add(prmEng);
                    SqlParameter prmMath = new SqlParameter("@Math", NudMath.Text);
                    cmd.Parameters.Add(prmMath);
                    double totalScore = (double)NudKor.Value + (double)NudEng.Value + (double)NudMath.Value;
                    double averageScore = totalScore / 3;
                    TxtAvg.Text = averageScore.ToString("0.0");
                    SqlParameter prmTotal = new SqlParameter("@Total", totalScore);
                    cmd.Parameters.Add(prmTotal);
                    SqlParameter prmAvg = new SqlParameter("@Avg", TxtAvg.Text);
                    cmd.Parameters.Add(prmAvg);
                    string grade = CalculateGrade(averageScore);
                    SqlParameter prmGrade = new SqlParameter("@Grade", grade);
                    cmd.Parameters.Add(prmGrade);
                    if (isNew != true)
                    {
                        SqlParameter prmStudentIdx = new SqlParameter("@studentIdx", TxtstudentIdx.Text);
                        cmd.Parameters.Add(prmStudentIdx);
                    }
 

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        //this �޼����ڽ��� �θ�â�� ������, FrmLoginUser
                        MessageBox.Show("���强��", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("���强��","����",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("�������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    TxtTotal.Text = TxtAvg.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���� : {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtstudentIdx.Text = TxtstudentName.Text = string.Empty;
            TxtstudentIdx.Focus();
            NudKor.Value = NudEng.Value = NudMath.Value = 0;
            RefreshData();
        }

        private string CalculateGrade(double averageScore)
        {
            if (averageScore >= 90)
                return "A";
            else if (averageScore >= 80)
                return "B";
            else if (averageScore >= 70)
                return "C";
            else if (averageScore >= 60)
                return "D";
            else
                return "F";
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtstudentIdx.Text)) //�����ڵ尡 ������
            {
                MessageBox.Show("������ ���а��� �����ϼ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MessageBox.Show("���� �����Ͻðڽ��ϱ�", "��������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM studenttbl WHERE studentIdx = @studentIdx";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmBookIdx = new SqlParameter("@studentIdx", TxtstudentIdx.Text);
                cmd.Parameters.Add(prmBookIdx);

                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("��������", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TxtstudentIdx.Text = TxtstudentName.Text = string.Empty;
                TxtstudentIdx.Focus();
                NudKor.Value = NudEng.Value = NudMath.Value = 0;
                RefreshData();
            }
        }
    }
}

