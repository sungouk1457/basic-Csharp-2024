using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toyproject
{
    public partial class FrmLogin : Form
    {
        private bool isLogin = false;

        public bool IsLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }

        public FrmLogin()
        {
            InitializeComponent();

            TxtUesrId.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;
            if (string.IsNullOrEmpty(TxtUesrId.Text))
            {
                isFail = true;
                errMsg += "아이디를 입력하세요\n";
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                isFail = true;
                errMsg += "패스워드를 입력하세요\n";
            }
            if (isFail == true)
            {
                MessageBox.Show(errMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            IsLogin = LoginProcess(); 
            if (IsLogin) this.Close();
        }

        private bool LoginProcess()
        {
            var md5Hash = MD5.Create();
            string userid = TxtUesrId.Text;
            string password = TxtPassword.Text;
            string chkUserId = string.Empty;
            string chkPassword = string.Empty;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                string query = @"SELECT userid
	                                  , [password]
                                   FROM usertbl
                                  WHERE userid = @userid
                                    AND [password] = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserId = new SqlParameter("@userid", userid);
                SqlParameter prmPassword = new SqlParameter("@Password", password);
                cmd.Parameters.Add(prmUserId);
                cmd.Parameters.Add(prmPassword);

                SqlDataReader reader = cmd.ExecuteReader(); 

                if (reader.Read())
                {
                    chkUserId = reader["userid"] != null ? reader["userid"].ToString() : "-";
                    chkPassword = reader["password"] != null ? reader["password"].ToString() : "-";
                    Helper.Common.LoginId = chkUserId;

                    return true;
                }
                else
                {
                    MessageBox.Show("로그인 정보가 없습니다", "DB오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } 
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TxtUesrId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus(); 
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
