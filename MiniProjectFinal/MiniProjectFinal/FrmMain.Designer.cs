namespace MiniProjectFinal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnMainLogin = new System.Windows.Forms.Button();
            this.TxtFindId = new System.Windows.Forms.TextBox();
            this.TxtFindPass = new System.Windows.Forms.TextBox();
            this.TxtJoin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("나눔바른고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(37, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(526, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "제이버를 더 안전하고 편리하게 이용하세요";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnMainLogin
            // 
            this.BtnMainLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnMainLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnMainLogin.Font = new System.Drawing.Font("나눔바른고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMainLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMainLogin.Location = new System.Drawing.Point(37, 124);
            this.BtnMainLogin.Name = "BtnMainLogin";
            this.BtnMainLogin.Size = new System.Drawing.Size(526, 83);
            this.BtnMainLogin.TabIndex = 1;
            this.BtnMainLogin.Text = "Javer 로그인 ";
            this.BtnMainLogin.UseVisualStyleBackColor = false;
            this.BtnMainLogin.Click += new System.EventHandler(this.BtnMainLogin_Click);
            // 
            // TxtFindId
            // 
            this.TxtFindId.BackColor = System.Drawing.SystemColors.Control;
            this.TxtFindId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFindId.Enabled = false;
            this.TxtFindId.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtFindId.Location = new System.Drawing.Point(105, 240);
            this.TxtFindId.Name = "TxtFindId";
            this.TxtFindId.Size = new System.Drawing.Size(100, 23);
            this.TxtFindId.TabIndex = 2;
            this.TxtFindId.Text = "아이디 찾기";
            this.TxtFindId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtFindPass
            // 
            this.TxtFindPass.BackColor = System.Drawing.SystemColors.Control;
            this.TxtFindPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFindPass.Enabled = false;
            this.TxtFindPass.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtFindPass.Location = new System.Drawing.Point(249, 240);
            this.TxtFindPass.Name = "TxtFindPass";
            this.TxtFindPass.Size = new System.Drawing.Size(121, 23);
            this.TxtFindPass.TabIndex = 3;
            this.TxtFindPass.Text = "비밀번호 찾기";
            this.TxtFindPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtJoin
            // 
            this.TxtJoin.BackColor = System.Drawing.SystemColors.Control;
            this.TxtJoin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtJoin.Enabled = false;
            this.TxtJoin.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtJoin.Location = new System.Drawing.Point(415, 240);
            this.TxtJoin.Name = "TxtJoin";
            this.TxtJoin.Size = new System.Drawing.Size(100, 23);
            this.TxtJoin.TabIndex = 4;
            this.TxtJoin.Text = "회원가입";
            this.TxtJoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(218, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(390, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(610, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJoin);
            this.Controls.Add(this.TxtFindPass);
            this.Controls.Add(this.TxtFindId);
            this.Controls.Add(this.BtnMainLogin);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnMainLogin;
        private System.Windows.Forms.TextBox TxtFindId;
        private System.Windows.Forms.TextBox TxtFindPass;
        private System.Windows.Forms.TextBox TxtJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

