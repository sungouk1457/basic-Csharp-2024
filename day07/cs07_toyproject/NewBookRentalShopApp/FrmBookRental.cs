﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmBookRental : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)
        
        public FrmBookRental()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            RefreshData(); //bookstbl에서 데이터를 가져오는 부분
            //콤보박스에 들어가는데이터를 초기화
            InitInputData(); //콤보박스, 날짜, NumericUpDown 컨트롤 데이터, 초기화
        }

        private void InitInputData()
        {
            //TODO 지금은 필요없음
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtRentalIdx.Text = TxtMemNames.Text = string.Empty;
            TxtMemberIdx.Text = TxtBookNames.Text = TxtBookIdx.Text = string.Empty;
            TxtRentalIdx.Focus(); //순번은 자동증가하기때문에 입력불가
            DtpRentalDate.Value = DtpReturnDate.Value = DateTime.Now;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //입력검증(Validation Check),아이디,패스워드를 안넣으면
            if (string.IsNullOrEmpty(TxtMemNames.Text))
            {
                MessageBox.Show("회원명을 선택하세요");
                return;
            }

            if (string.IsNullOrEmpty(TxtBookNames.Text))
            {
                MessageBox.Show("대출할 책을 선택하세요");
                return;
            }

            //반납일 1800-01-01이면 반납일에 null을 입력

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) //INSERT이면
                    {
                        query = @"INSERT INTO [dbo].[rentaltbl]
                                           ([memberIdx]
                                           ,[bookIdx]
                                           ,[rentalDate]
                                           ,[returnDate])
                                     VALUES
                                           (@memberIdx
                                           ,@bookIdx
                                           ,@rentalDate
                                           ,@returnDate)";
                    }
                    else //UPDATE
                    {
                        query = @"UPDATE [dbo].[rentaltbl]
                                     SET [memberIdx] = @memberIdx
                                        ,[bookIdx] = @bookIdx
                                        ,[rentalDate] = @rentalDate
                                        ,[returnDate] = @returnDate
                                   WHERE rentalIdx = @rentalIdx";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlParameter prmMemberIdx = new SqlParameter("@memberIdx", TxtMemberIdx.Text);
                    cmd.Parameters.Add(prmMemberIdx);
                    SqlParameter prmBookIdx = new SqlParameter("@bookIdx", TxtBookIdx.Text);
                    cmd.Parameters.Add(prmBookIdx);
                    SqlParameter prmRentalDate = new SqlParameter("@rentalDate", DtpRentalDate.Value);
                    cmd.Parameters.Add(prmRentalDate);
                    var returnDate = "";//반납날짜때문에 추가처리
                    if(DtpReturnDate.Value <= DtpRentalDate.Value) //대출일보다 반납일이 뒤의날짜가 되어야 함
                    {
                        returnDate = "";
                    }
                    else
                    {
                        returnDate = DtpReturnDate.Value.ToString("yyyy-MM-dd");
                    }
                    SqlParameter prmReturnDate = new SqlParameter("returnDate", returnDate);
                    cmd.Parameters.Add(prmReturnDate);

                    if (isNew != true)
                    {
                        SqlParameter prmrentalIdx = new SqlParameter("@rentalIdx", TxtRentalIdx.Text);
                        cmd.Parameters.Add(prmrentalIdx);
                    }

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        //this 메세지박스의 부모창이 누구냐, FrmLoginUser
                        MetroMessageBox.Show(this, "저장성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장성공","저장",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장실패", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtRentalIdx.Text = TxtMemNames.Text = string.Empty; //입력, 수정, 삭제 이후에는 모든 입력값을 지워줘야 함
            DtpReturnDate.Value = DateTime.Now;
            RefreshData();
        }

        //데이터그리드뷰에 데이터를 새로부르기 
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                var query = @"SELECT r.rentalIdx
                                   , r.memberIdx
	                               , m.Names AS memNames
                                   , r.bookIdx
	                               , b.Names AS bookNames
                                   , r.rentalDate
                                   , r.returnDate
                                FROM rentaltbl AS r
                                JOIN membertbl AS m
                                  ON r.memberIdx = m.memberIdx
                                JOIN bookstbl AS b
                                  ON r.bookIdx = b.bookIdx";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "rentaltbl"); //대표 테이블이름 사용

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; //수정불가
                DgvResult.Columns[0].HeaderText = "대출순번";
                DgvResult.Columns[1].HeaderText = "회원순번";
                DgvResult.Columns[2].HeaderText = "회원명";
                DgvResult.Columns[3].HeaderText = "책순번"; 
                DgvResult.Columns[4].HeaderText = "책제목";
                DgvResult.Columns[5].HeaderText = "대출일";
                DgvResult.Columns[6].HeaderText = "반납일";

                //각 컬럼 넓이, 컬럼 숨김 지정
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1) //아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; //내가 선택한 인덱스값              
                TxtRentalIdx.Text = selData.Cells[0].Value.ToString(); //대출순번
                TxtMemberIdx.Text = selData.Cells[1].Value.ToString(); //회원순번
                TxtMemNames.Text = selData.Cells[2].Value.ToString(); //회원명
                TxtBookIdx.Text = selData.Cells[3].Value.ToString(); //책순번
                TxtBookNames.Text = selData.Cells[4].Value.ToString(); //책제목
                DtpRentalDate.Value = DateTime.Parse(selData.Cells[5].Value.ToString());
                DtpReturnDate.Value = string.IsNullOrEmpty(selData.Cells[6].Value.ToString())? 
                                      DateTime.Parse(selData.Cells[6].Value.ToString()) : 
                                      DateTime.Parse("1800-01-01"); //

                isNew = false; //UPDATE
            }
        }

        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            PopMember popup = new PopMember();
            popup.StartPosition = FormStartPosition.CenterParent;
            if(popup.ShowDialog() == DialogResult.Yes)
            {
                TxtMemberIdx.Text = Helper.Common.SelMemberIdx;
                TxtMemNames.Text = Helper.Common.SelMemberName;
            }
        }

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            PopBook popup = new PopBook();
            popup.StartPosition = FormStartPosition.CenterParent;
            if (popup.ShowDialog() == DialogResult.Yes)
            {
                TxtBookIdx.Text = Helper.Common.SelBookIdx;
                TxtBookNames.Text = Helper.Common.SelBookName;
            }
        }
    }
}
