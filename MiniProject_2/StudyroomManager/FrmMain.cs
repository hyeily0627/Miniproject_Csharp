using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StudyroomManager
{
    public partial class FrmMain : MetroForm
    {
        FrmSeat seat = null;


        public FrmMain()
        {
            InitializeComponent();
        }

        #region 폼로드 이벤트 핸들러 : 로딩창 먼저 띄우기! 

        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            using (FrmLoading frm = new FrmLoading())
            {
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.TopMost = true;  // 윈도우 화면 상단에 
                frm.ShowDialog();
            }
        }

        #endregion



        #region 창 컨트롤링
        Form ShowActiveForm(Form form, Type type)
        {
            if (form == null) // 화면이 한번도 안열렸으면 
            {
                form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입 
                form.MdiParent = this; // 자식창의 부모는 FrmMain 
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if (form.IsDisposed) // 화면이 한번이라도 닫혔으면 
                {
                    form = Activator.CreateInstance(type) as Form; // 타입은 클래스 타입 
                    form.MdiParent = this; // 자식창의 부모는 FrmMain 
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else // 창을 그냥 최소화, 열려있으면! 
                {
                    form.Activate(); // 화면에 열려있는 창을 활성화 
                }
            }
            return form;
            
        }
        #endregion

        
    }

}
