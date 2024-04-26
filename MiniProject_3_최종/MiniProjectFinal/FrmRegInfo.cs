using MetroFramework;
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

namespace MiniProjectFinal
{
    public partial class FrmRegInfo : Form
    {
        private bool isNew = false;  // UPDATE(false), INSERT(true) 

        public FrmRegInfo()
        {
            InitializeComponent();

            Cbotelecom.Items.Add("SKT");
            Cbotelecom.Items.Add("KT");
            Cbotelecom.Items.Add("LG U+");
            Cbotelecom.Items.Add("SKT 알뜰폰");
            Cbotelecom.Items.Add("KT 알뜰폰");
            Cbotelecom.Items.Add("LG U+ 알뜰폰");


            // 콤보박스의 기본 선택 항목 설정
            Cbotelecom.SelectedIndex = 0; // 첫 번째 항목을 기본으로 선택
        }

        // '신규'버튼 클릭 이벤트 핸들러 
        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtUserId.Text = TxtPassword.Text = string.Empty;
            
        }

        // '저장'버튼 클릭 이벤트 핸들러 
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var md5hash = MD5.Create();

            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("사용자 아이디를 입력하세요.");
                return;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("패스워드을 입력하세요.");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO usertbl
                                       (userid
                                       ,[password])
                                 VALUES
                                       (@userid
                                       ,@password)";
                    }
                    else // UPDATE 
                    {
                        query = @"UPDATE usertbl
                                 SET userid = @userid
                                   ,[password] = @password
                               WHERE useridx = @useridx";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (isNew == false) // UPDATE 시에는 @userIdx 파라미터 필요! 
                    {
                        //SqlParameter prmUserNumber = new SqlParameter("useridx", TxtUserNumber.Text);
                        //cmd.Parameters.Add(prmUserNumber);
                    }
                    SqlParameter prmUserId = new SqlParameter("userId", TxtUserId.Text);
                    SqlParameter prmPassword = new SqlParameter("password", Helper.Common.GetMd5Hash(md5hash, TxtPassword.Text));
                    // Command 에 Parameter를 연결해줘야함 
                    cmd.Parameters.Add(prmUserId);
                    cmd.Parameters.Add(prmPassword);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메세지박스의 부모창이 누구냐, FrmLoginUser
                        MetroMessageBox.Show(this, "저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("저장실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region 단일 선택 버튼 (남녀, 내외국인)
        private void btnMale_Click(object sender, EventArgs e)
        {
            // 남자 버튼 클릭 시 여자 버튼 선택 해제 및 상태 업데이트
            btnFemale.Checked = false;
            btnMale.Checked = true;
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            // 여자 버튼 클릭 시 남자 버튼 선택 해제 및 상태 업데이트
            btnMale.Checked = false;
            btnFemale.Checked = true;
        }

        // 내외국인
        private void BtnIIn_Click(object sender, EventArgs e)
        {
            BtnIn.Checked = false;
            BtnOut.Checked = true;
        }

        private void BtnIOut_Click(object sender, EventArgs e)
        {
            BtnIn.Checked = false;
            BtnOut.Checked = true;
        }
        #endregion


    }

}
