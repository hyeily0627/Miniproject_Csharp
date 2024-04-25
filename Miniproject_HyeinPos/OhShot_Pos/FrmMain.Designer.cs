namespace OhShot_Pos
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.BtnStat = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TblPanel
            // 
            this.TblPanel.ColumnCount = 2;
            this.TblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0473F));
            this.TblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.9527F));
            this.TblPanel.Location = new System.Drawing.Point(17, 19);
            this.TblPanel.Name = "TblPanel";
            this.TblPanel.RowCount = 3;
            this.TblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.TblPanel.Size = new System.Drawing.Size(1057, 730);
            this.TblPanel.TabIndex = 0;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(1191, 56);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(53, 12);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "현재날짜";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(1191, 167);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(53, 12);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "현재시간";
            // 
            // BtnStat
            // 
            this.BtnStat.Location = new System.Drawing.Point(1089, 576);
            this.BtnStat.Name = "BtnStat";
            this.BtnStat.Size = new System.Drawing.Size(283, 78);
            this.BtnStat.TabIndex = 2;
            this.BtnStat.Text = "매출 통계";
            this.BtnStat.UseVisualStyleBackColor = true;
            this.BtnStat.Click += new System.EventHandler(this.BtnStat_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(1089, 671);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(283, 78);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "포스기 종료";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnStat);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.TblPanel);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPanel;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Button BtnStat;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer timer1;
    }
}

