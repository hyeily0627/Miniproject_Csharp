namespace MiniProjectFinal
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.CboGrobal = new System.Windows.Forms.ComboBox();
            this.ChkAll = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ChkTermsofUse = new System.Windows.Forms.CheckBox();
            this.TxtTermsofUse = new System.Windows.Forms.TextBox();
            this.ChkPersonalData = new System.Windows.Forms.CheckBox();
            this.TxtPersonalData = new System.Windows.Forms.TextBox();
            this.Chkcertified = new System.Windows.Forms.CheckBox();
            this.Txtcertified = new System.Windows.Forms.TextBox();
            this.ChkLocation = new System.Windows.Forms.CheckBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.ChkAllow = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboGrobal
            // 
            this.CboGrobal.Font = new System.Drawing.Font("나눔스퀘어", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CboGrobal.FormattingEnabled = true;
            this.CboGrobal.Location = new System.Drawing.Point(410, 32);
            this.CboGrobal.Name = "CboGrobal";
            this.CboGrobal.Size = new System.Drawing.Size(118, 29);
            this.CboGrobal.TabIndex = 11;
            // 
            // ChkAll
            // 
            this.ChkAll.AutoSize = true;
            this.ChkAll.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkAll.Location = new System.Drawing.Point(42, 95);
            this.ChkAll.Name = "ChkAll";
            this.ChkAll.Size = new System.Drawing.Size(136, 25);
            this.ChkAll.TabIndex = 12;
            this.ChkAll.Text = "전체 동의하기";
            this.ChkAll.UseVisualStyleBackColor = true;
            this.ChkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(62, 123);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(466, 40);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "실명 인증된 아이디로 가입, 위치기반서비스 이용약관(선택), 이벤트・혜택 정보 수신(선택) 동의를 포함합니다.";
            // 
            // ChkTermsofUse
            // 
            this.ChkTermsofUse.AutoSize = true;
            this.ChkTermsofUse.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkTermsofUse.Location = new System.Drawing.Point(42, 180);
            this.ChkTermsofUse.Name = "ChkTermsofUse";
            this.ChkTermsofUse.Size = new System.Drawing.Size(201, 25);
            this.ChkTermsofUse.TabIndex = 12;
            this.ChkTermsofUse.Text = "[필수]제이버 이용약관";
            this.ChkTermsofUse.UseVisualStyleBackColor = true;
            // 
            // TxtTermsofUse
            // 
            this.TxtTermsofUse.BackColor = System.Drawing.SystemColors.Control;
            this.TxtTermsofUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTermsofUse.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtTermsofUse.Location = new System.Drawing.Point(62, 211);
            this.TxtTermsofUse.Multiline = true;
            this.TxtTermsofUse.Name = "TxtTermsofUse";
            this.TxtTermsofUse.ReadOnly = true;
            this.TxtTermsofUse.Size = new System.Drawing.Size(466, 40);
            this.TxtTermsofUse.TabIndex = 14;
            this.TxtTermsofUse.Text = resources.GetString("TxtTermsofUse.Text");
            // 
            // ChkPersonalData
            // 
            this.ChkPersonalData.AutoSize = true;
            this.ChkPersonalData.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkPersonalData.Location = new System.Drawing.Point(42, 268);
            this.ChkPersonalData.Name = "ChkPersonalData";
            this.ChkPersonalData.Size = new System.Drawing.Size(245, 25);
            this.ChkPersonalData.TabIndex = 12;
            this.ChkPersonalData.Text = "[필수]개인정보 수집 및 이용";
            this.ChkPersonalData.UseVisualStyleBackColor = true;
            // 
            // TxtPersonalData
            // 
            this.TxtPersonalData.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPersonalData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPersonalData.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtPersonalData.Location = new System.Drawing.Point(62, 299);
            this.TxtPersonalData.Multiline = true;
            this.TxtPersonalData.Name = "TxtPersonalData";
            this.TxtPersonalData.ReadOnly = true;
            this.TxtPersonalData.Size = new System.Drawing.Size(466, 40);
            this.TxtPersonalData.TabIndex = 15;
            this.TxtPersonalData.Text = resources.GetString("TxtPersonalData.Text");
            // 
            // Chkcertified
            // 
            this.Chkcertified.AutoSize = true;
            this.Chkcertified.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Chkcertified.Location = new System.Drawing.Point(42, 356);
            this.Chkcertified.Name = "Chkcertified";
            this.Chkcertified.Size = new System.Drawing.Size(279, 25);
            this.Chkcertified.TabIndex = 12;
            this.Chkcertified.Text = "[필수]실명 인증된 아이디로 가입";
            this.Chkcertified.UseVisualStyleBackColor = true;
            // 
            // Txtcertified
            // 
            this.Txtcertified.BackColor = System.Drawing.SystemColors.Control;
            this.Txtcertified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtcertified.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Txtcertified.Location = new System.Drawing.Point(62, 387);
            this.Txtcertified.Multiline = true;
            this.Txtcertified.Name = "Txtcertified";
            this.Txtcertified.ReadOnly = true;
            this.Txtcertified.Size = new System.Drawing.Size(466, 40);
            this.Txtcertified.TabIndex = 15;
            this.Txtcertified.Text = "실명 인증된 아이디로 가입하시면 본인인증이 필요한 서비스(네이버 페이, 쇼핑, 멤버십 등)를 가입 후 바로 이용하실 수 있어요.";
            // 
            // ChkLocation
            // 
            this.ChkLocation.AutoSize = true;
            this.ChkLocation.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkLocation.Location = new System.Drawing.Point(42, 447);
            this.ChkLocation.Name = "ChkLocation";
            this.ChkLocation.Size = new System.Drawing.Size(269, 25);
            this.ChkLocation.TabIndex = 12;
            this.ChkLocation.Text = "[필수]위치기반서비스 이용약관";
            this.ChkLocation.UseVisualStyleBackColor = true;
            // 
            // TxtLocation
            // 
            this.TxtLocation.BackColor = System.Drawing.SystemColors.Control;
            this.TxtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLocation.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtLocation.Location = new System.Drawing.Point(62, 478);
            this.TxtLocation.Multiline = true;
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.ReadOnly = true;
            this.TxtLocation.Size = new System.Drawing.Size(466, 40);
            this.TxtLocation.TabIndex = 15;
            this.TxtLocation.Text = "위치기반서비스 이용약관에 동의하시면, 위치를 활용한 광고 정보 수신 등을 포함하는 네이버 위치기반 서비스를 이용할 수 있습니다.";
            // 
            // ChkAllow
            // 
            this.ChkAllow.AutoSize = true;
            this.ChkAllow.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkAllow.Location = new System.Drawing.Point(42, 540);
            this.ChkAllow.Name = "ChkAllow";
            this.ChkAllow.Size = new System.Drawing.Size(245, 25);
            this.ChkAllow.TabIndex = 12;
            this.ChkAllow.Text = "[선택]개인정보 수집 및 이용";
            this.ChkAllow.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(348, 704);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 18);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "단체, 비즈니스 회원 가입 >";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnNext.Font = new System.Drawing.Font("나눔스퀘어_ac ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNext.Location = new System.Drawing.Point(42, 602);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(491, 83);
            this.BtnNext.TabIndex = 21;
            this.BtnNext.Text = "다음";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::MiniProjectFinal.Properties.Resources.global;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(376, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Javer";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.Txtcertified);
            this.Controls.Add(this.TxtPersonalData);
            this.Controls.Add(this.TxtTermsofUse);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ChkAllow);
            this.Controls.Add(this.ChkLocation);
            this.Controls.Add(this.Chkcertified);
            this.Controls.Add(this.ChkPersonalData);
            this.Controls.Add(this.ChkTermsofUse);
            this.Controls.Add(this.ChkAll);
            this.Controls.Add(this.CboGrobal);
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CboGrobal;
        private System.Windows.Forms.CheckBox ChkAll;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox ChkTermsofUse;
        private System.Windows.Forms.TextBox TxtTermsofUse;
        private System.Windows.Forms.CheckBox ChkPersonalData;
        private System.Windows.Forms.TextBox TxtPersonalData;
        private System.Windows.Forms.CheckBox Chkcertified;
        private System.Windows.Forms.TextBox Txtcertified;
        private System.Windows.Forms.CheckBox ChkLocation;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.CheckBox ChkAllow;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label label1;
    }
}