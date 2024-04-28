using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MiniProjectFinal
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        #region 'Javer로그인'버튼 클릭 이벤트  
        private void BtnMainLogin_Click(object sender, EventArgs e)
        {
            FrmLogin popup = new FrmLogin();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
        #endregion

        #region 비밀번호,아이디,회원가입 버튼 클릭 이벤트 
        // '비밀번호 찾기' 클릭 버튼 이벤트
        private void LblFindPass_Click(object sender, EventArgs e)
        {
            FrmFindPassword popup = new FrmFindPassword();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }

        // '아이디 찾기' 클릭 버튼 이벤트
        private void LbFindId_Click(object sender, EventArgs e)
        {
            FrmFindId popup = new FrmFindId();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }

        // '회원가입' 클릭 버튼 이벤트
        private void LblUserJoin_Click(object sender, EventArgs e)
        {
            FrmRegister popup = new FrmRegister();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }
    }
}
