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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();

            #region '이용약관' 스크롤 텍스트 박스
            // 텍스트 상자에 긴 텍스트 추가
            TxtTermsofUse.Multiline = true; // 여러 줄 텍스트 상자로 설정
            TxtTermsofUse.ScrollBars = ScrollBars.Vertical; // 세로 스크롤바 추가
            for (int i = 0; i < 100; i++)
            {
                TxtTermsofUse.Text += "Line " + i.ToString() + "\n";
            }
            #endregion

            #region '개인정보' 스크롤 텍스트 박스
            // 텍스트 상자에 긴 텍스트 추가
            TxtPersonalData.Multiline = true; // 여러 줄 텍스트 상자로 설정
            TxtPersonalData.ScrollBars = ScrollBars.Vertical; // 세로 스크롤바 추가
            for (int i = 0; i < 100; i++)
            {
                TxtPersonalData.Text += "Line " + i.ToString() + "\n";
            }
            #endregion

            #region '위치정보' 스크롤 텍스트 박스
            // 텍스트 상자에 긴 텍스트 추가
            TxtLocation.Multiline = true; // 여러 줄 텍스트 상자로 설정
            TxtLocation.ScrollBars = ScrollBars.Vertical; // 세로 스크롤바 추가
            for (int i = 0; i < 100; i++)
            {
                TxtLocation.Text += "Line " + i.ToString() + "\n";
            }
            #endregion

            #region '언어선택 콤보박스'
            CboGrobal.Items.Add("한국어");
            CboGrobal.Items.Add("English");
            CboGrobal.Items.Add("中文");
            CboGrobal.Items.Add("日本語");
            CboGrobal.Items.Add("русский");

            // 콤보박스의 기본 선택 항목 설정
            CboGrobal.SelectedIndex = 0; // 첫 번째 항목을 기본으로 선택
            #endregion
        }

        #region 콤보박스 이벤트 핸들러 (전체동의 및 개별 컨트롤)
        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            // 전체동의하기에 체크하면 나머지 박스들도 일괄적으로 체크 
            if (ChkAll.Checked)
            {
                ChkTermsofUse.Checked = true;
                ChkPersonalData.Checked = true;
                Chkcertified.Checked = true;
                ChkLocation.Checked = true;
                ChkAllow.Checked = true;
            }
            else
            {
                ChkTermsofUse.Checked = false;
                ChkPersonalData.Checked = false;
                Chkcertified.Checked = false;
                ChkLocation.Checked = false;
                ChkAllow.Checked = false;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // 모든 체크박스가 선택되었는지 확인
            if (ChkTermsofUse.Checked && ChkPersonalData.Checked && Chkcertified.Checked && ChkLocation.Checked)
            {
                // 필수 항목 전부 클릭 되었으면 회원가입 폼으로 이동 
                FrmRegInfo popup = new FrmRegInfo();
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.ShowDialog();
            }
            else
            {
                // 필수 항목 하나라도 빠졌으면 경고창 표시
                MessageBox.Show("필수 항목 체크는 필수입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
