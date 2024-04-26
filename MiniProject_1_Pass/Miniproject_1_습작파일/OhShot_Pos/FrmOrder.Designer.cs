namespace OhShot_Pos
{
    partial class FrmOrder
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
            this.backBtn = new System.Windows.Forms.Button();
            this.tableNum = new System.Windows.Forms.Label();
            this.nowDateTIme = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.AllViewBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AllCancelBtn = new System.Windows.Forms.Button();
            this.MenuTablePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(30, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(265, 92);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "메인으로 돌아가기";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tableNum
            // 
            this.tableNum.AutoSize = true;
            this.tableNum.Location = new System.Drawing.Point(340, 63);
            this.tableNum.Name = "tableNum";
            this.tableNum.Size = new System.Drawing.Size(88, 20);
            this.tableNum.TabIndex = 1;
            this.tableNum.Text = "tableNum";
            // 
            // nowDateTIme
            // 
            this.nowDateTIme.AutoSize = true;
            this.nowDateTIme.Location = new System.Drawing.Point(556, 63);
            this.nowDateTIme.Name = "nowDateTIme";
            this.nowDateTIme.Size = new System.Drawing.Size(123, 20);
            this.nowDateTIme.TabIndex = 1;
            this.nowDateTIme.Text = "nowDateTIme";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(774, 63);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(90, 20);
            this.totalPrice.TabIndex = 1;
            this.totalPrice.Text = "totalPrice";
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(993, 27);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(265, 92);
            this.PaymentBtn.TabIndex = 0;
            this.PaymentBtn.Text = "결제";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // AllViewBtn
            // 
            this.AllViewBtn.Location = new System.Drawing.Point(690, 125);
            this.AllViewBtn.Name = "AllViewBtn";
            this.AllViewBtn.Size = new System.Drawing.Size(568, 67);
            this.AllViewBtn.TabIndex = 0;
            this.AllViewBtn.Text = "전체보기";
            this.AllViewBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(654, 336);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 467);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 405);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(480, 467);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(204, 64);
            this.OrderBtn.TabIndex = 0;
            this.OrderBtn.Text = "주문하기";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(480, 551);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(204, 64);
            this.PlusBtn.TabIndex = 0;
            this.PlusBtn.Text = "품목증가";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Location = new System.Drawing.Point(480, 638);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(204, 64);
            this.MinusBtn.TabIndex = 0;
            this.MinusBtn.Text = "품목제거";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(480, 723);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(204, 64);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "단품취소";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AllCancelBtn
            // 
            this.AllCancelBtn.Location = new System.Drawing.Point(480, 808);
            this.AllCancelBtn.Name = "AllCancelBtn";
            this.AllCancelBtn.Size = new System.Drawing.Size(204, 64);
            this.AllCancelBtn.TabIndex = 0;
            this.AllCancelBtn.Text = "전체취소";
            this.AllCancelBtn.UseVisualStyleBackColor = true;
            this.AllCancelBtn.Click += new System.EventHandler(this.AllCancelBtn_Click);
            // 
            // MenuTablePanel
            // 
            this.MenuTablePanel.Location = new System.Drawing.Point(699, 203);
            this.MenuTablePanel.Name = "MenuTablePanel";
            this.MenuTablePanel.Size = new System.Drawing.Size(558, 668);
            this.MenuTablePanel.TabIndex = 4;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 888);
            this.Controls.Add(this.MenuTablePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.nowDateTIme);
            this.Controls.Add(this.tableNum);
            this.Controls.Add(this.AllViewBtn);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.AllCancelBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.backBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label tableNum;
        private System.Windows.Forms.Label nowDateTIme;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button AllViewBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AllCancelBtn;
        private System.Windows.Forms.Panel MenuTablePanel;
    }
}