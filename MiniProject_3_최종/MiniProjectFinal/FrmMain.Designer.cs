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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblFindPass = new System.Windows.Forms.Label();
            this.LbFindId = new System.Windows.Forms.Label();
            this.LblUserJoin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어_ac", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(37, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(526, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "제이버를 더 안전하고 편리하게 이용하세요";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(218, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(390, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // LblFindPass
            // 
            this.LblFindPass.AutoSize = true;
            this.LblFindPass.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFindPass.Location = new System.Drawing.Point(100, 239);
            this.LblFindPass.Name = "LblFindPass";
            this.LblFindPass.Size = new System.Drawing.Size(102, 18);
            this.LblFindPass.TabIndex = 6;
            this.LblFindPass.Text = "비밀번호 찾기";
            this.LblFindPass.Click += new System.EventHandler(this.LblFindPass_Click);
            // 
            // LbFindId
            // 
            this.LbFindId.AutoSize = true;
            this.LbFindId.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFindId.Location = new System.Drawing.Point(263, 239);
            this.LbFindId.Name = "LbFindId";
            this.LbFindId.Size = new System.Drawing.Size(87, 18);
            this.LbFindId.TabIndex = 6;
            this.LbFindId.Text = "아이디 찾기";
            this.LbFindId.Click += new System.EventHandler(this.LbFindId_Click);
            // 
            // LblUserJoin
            // 
            this.LblUserJoin.AutoSize = true;
            this.LblUserJoin.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserJoin.Location = new System.Drawing.Point(430, 239);
            this.LblUserJoin.Name = "LblUserJoin";
            this.LblUserJoin.Size = new System.Drawing.Size(68, 18);
            this.LblUserJoin.TabIndex = 6;
            this.LblUserJoin.Text = "회원가입";
            this.LblUserJoin.Click += new System.EventHandler(this.LblUserJoin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProjectFinal.Properties.Resources.btnImage;
            this.pictureBox1.Location = new System.Drawing.Point(38, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 79);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BtnMainLogin_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(610, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblUserJoin);
            this.Controls.Add(this.LbFindId);
            this.Controls.Add(this.LblFindPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblFindPass;
        private System.Windows.Forms.Label LbFindId;
        private System.Windows.Forms.Label LblUserJoin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

