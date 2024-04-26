using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectFinal
{
    public partial class FrmLogin : Form
    {
        private bool isLogin = false;
        private bool IsLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region ID에서 엔터를 누르면 패스워드로 포커스 이동 
        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 13  = 엔터키!
            {
                TxtPassword.Focus();
            }
        }
        #endregion

        #region 패스워드에서 엔터를 누르면 로그인 버튼 클릭
        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 13  = 엔터키!
            {
                BtnLogin_Click(sender, e);
            }
        }
        #endregion

        #region 비밀번호,아이디,회원가입 버튼 클릭 이벤트 
        // '비밀번호 찾기' 클릭 버튼 이벤트
        private void LblFindPass2_Click(object sender, EventArgs e)
        {
            FrmFindPassword popup = new FrmFindPassword();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }

        // '아이디 찾기' 클릭 버튼 이벤트
        private void LblFindId2_Click(object sender, EventArgs e)
        {
            FrmFindId popup = new FrmFindId();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }

        // '회원가입' 클릭 버튼 이벤트
        private void LblUserJoin2_Click(object sender, EventArgs e)
        {
            FrmRegister popup = new FrmRegister();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
        #endregion

        #region 로그인버튼 클릭 이벤트 핸들러
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;

            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                isFail = true;
                errMsg += "아이디를 입력하세요.\n";
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                isFail = true;
                errMsg += "패스워드를 입력하세요.\n";
            }
            if (isFail == true)
            {
                MessageBox.Show(errMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // DB연계
            IsLogin = LoginProcess();  // 로그인 성공시 True, 실패시 False 리턴함 
            if (IsLogin) this.Close();  // 현재 로그인창 닫기 
        }
        #endregion

        // 로그인 DB 처리 
        private bool LoginProcess()
        {
            var md5hash = MD5.Create();
            string userid = TxtUserId.Text;        // 현재 DB로 넘기는 값
            string password = TxtPassword.Text;
            string chkUserId = string.Empty;      // DB에서 넘어온 값 
            string chkPassword = string.Empty;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                // @userid, @password 쿼리문 외부에서 변수값을 안전하게 주입함
                string query = @"SELECT userID
	                                   ,password
                                   FROM usertbl
                                  WHERE userid = @userId
                                    AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                // @userid, @password 파라미터 할당
                SqlParameter prmUserid = new SqlParameter("@userId", userid);
                SqlParameter prmPassword = new SqlParameter("@Password", Helper.Common.GetMd5Hash(md5hash, password));
                cmd.Parameters.Add(prmUserid);
                cmd.Parameters.Add(prmPassword);

                SqlDataReader reader = cmd.ExecuteReader(); // 

                if (reader.Read())
                {
                    chkUserId = reader["userid"] != null ? reader["userid"].ToString() : "-";
                    // 유저 아이디가 null 일때  -로 변경 
                    chkPassword = reader["password"] != null ? reader["password"].ToString() : "-";
                    // 패스워드가 null 일때 -로 변경 
                    Helper.Common.LoginId = chkUserId; // 로그인 된 아이디 

                    return true;
                }
                else
                {
                    MessageBox.Show("로그인 정보가 없습니다.", "DB오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

            } // using을 사용하면 conn.Close()가 필요 없음
        }
    }
} 
