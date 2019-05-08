namespace WindowsFormsApplication1
{
    partial class UW
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbNoise = new System.Windows.Forms.CheckBox();
            this.ckbLangcan = new System.Windows.Forms.CheckBox();
            this.ckbHapthu = new System.Windows.Forms.CheckBox();
            this.ckbHinhhoc = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSalinity = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtpH = new System.Windows.Forms.TextBox();
            this.txtDeep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbLC = new System.Windows.Forms.GroupBox();
            this.cbxGround = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbNoise = new System.Windows.Forms.GroupBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbLC.SuspendLayout();
            this.grbNoise.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDistance);
            this.groupBox1.Controls.Add(this.txtFreq);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông số cơ bản";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(24, 107);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(144, 20);
            this.txtDistance.TabIndex = 3;
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(21, 50);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(147, 20);
            this.txtFreq.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoảng cách truyền [m]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tần số sóng mang [kHz]:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbNoise);
            this.groupBox2.Controls.Add(this.ckbLangcan);
            this.groupBox2.Controls.Add(this.ckbHapthu);
            this.groupBox2.Controls.Add(this.ckbHinhhoc);
            this.groupBox2.Location = new System.Drawing.Point(300, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suy hao";
            // 
            // ckbNoise
            // 
            this.ckbNoise.AutoSize = true;
            this.ckbNoise.Location = new System.Drawing.Point(31, 104);
            this.ckbNoise.Name = "ckbNoise";
            this.ckbNoise.Size = new System.Drawing.Size(162, 17);
            this.ckbNoise.TabIndex = 3;
            this.ckbNoise.Text = "Nhiễu tàu thuyền, gió, nhiệt,.";
            this.ckbNoise.UseVisualStyleBackColor = true;
            this.ckbNoise.CheckStateChanged += new System.EventHandler(this.ckbNoise_CheckStateChanged);
            // 
            // ckbLangcan
            // 
            this.ckbLangcan.AutoSize = true;
            this.ckbLangcan.Location = new System.Drawing.Point(31, 81);
            this.ckbLangcan.Name = "ckbLangcan";
            this.ckbLangcan.Size = new System.Drawing.Size(148, 17);
            this.ckbLangcan.TabIndex = 2;
            this.ckbLangcan.Text = "Suy hao do chất lắng cặn";
            this.ckbLangcan.UseVisualStyleBackColor = true;
            this.ckbLangcan.CheckStateChanged += new System.EventHandler(this.ckbLangcan_CheckStateChanged);
            // 
            // ckbHapthu
            // 
            this.ckbHapthu.AutoSize = true;
            this.ckbHapthu.Location = new System.Drawing.Point(31, 58);
            this.ckbHapthu.Name = "ckbHapthu";
            this.ckbHapthu.Size = new System.Drawing.Size(119, 17);
            this.ckbHapthu.TabIndex = 1;
            this.ckbHapthu.Text = "Suy hao do hấp thụ";
            this.ckbHapthu.UseVisualStyleBackColor = true;
            // 
            // ckbHinhhoc
            // 
            this.ckbHinhhoc.AutoSize = true;
            this.ckbHinhhoc.Location = new System.Drawing.Point(31, 35);
            this.ckbHinhhoc.Name = "ckbHinhhoc";
            this.ckbHinhhoc.Size = new System.Drawing.Size(129, 17);
            this.ckbHinhhoc.TabIndex = 0;
            this.ckbHinhhoc.Text = "Suy hao trải hình học:";
            this.ckbHinhhoc.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSalinity);
            this.groupBox3.Controls.Add(this.txtTemp);
            this.groupBox3.Controls.Add(this.txtpH);
            this.groupBox3.Controls.Add(this.txtDeep);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(52, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suy hao do hấp thụ";
            // 
            // txtSalinity
            // 
            this.txtSalinity.Location = new System.Drawing.Point(7, 104);
            this.txtSalinity.Name = "txtSalinity";
            this.txtSalinity.Size = new System.Drawing.Size(71, 20);
            this.txtSalinity.TabIndex = 7;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(106, 104);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(71, 20);
            this.txtTemp.TabIndex = 6;
            // 
            // txtpH
            // 
            this.txtpH.Location = new System.Drawing.Point(106, 51);
            this.txtpH.Name = "txtpH";
            this.txtpH.Size = new System.Drawing.Size(74, 20);
            this.txtpH.TabIndex = 5;
            // 
            // txtDeep
            // 
            this.txtDeep.Location = new System.Drawing.Point(7, 51);
            this.txtDeep.Name = "txtDeep";
            this.txtDeep.Size = new System.Drawing.Size(71, 20);
            this.txtDeep.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhiệt độ [C]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Độ mặn [ppt]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "pH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Độ sâu [m]:";
            // 
            // grbLC
            // 
            this.grbLC.Controls.Add(this.cbxGround);
            this.grbLC.Controls.Add(this.label7);
            this.grbLC.Enabled = false;
            this.grbLC.Location = new System.Drawing.Point(300, 219);
            this.grbLC.Name = "grbLC";
            this.grbLC.Size = new System.Drawing.Size(200, 90);
            this.grbLC.TabIndex = 3;
            this.grbLC.TabStop = false;
            this.grbLC.Text = "Suy hao do chất lắng cặn";
            // 
            // cbxGround
            // 
            this.cbxGround.FormattingEnabled = true;
            this.cbxGround.Items.AddRange(new object[] {
            "Bùn rất mịn",
            "Cát mịn",
            "Cát trung bình",
            "Cát thô"});
            this.cbxGround.Location = new System.Drawing.Point(34, 68);
            this.cbxGround.Name = "cbxGround";
            this.cbxGround.Size = new System.Drawing.Size(121, 21);
            this.cbxGround.TabIndex = 1;
            this.cbxGround.Text = "Bùn rất mịn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đặc điểm của đáy:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(62, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(157, 401);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 42);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(300, 401);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 42);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "Tính toán suy hao";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(396, 423);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kết quả [dB]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(442, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tính toán suy hao kênh truyền dưới nước";
            // 
            // grbNoise
            // 
            this.grbNoise.Controls.Add(this.label10);
            this.grbNoise.Controls.Add(this.txtWind);
            this.grbNoise.Location = new System.Drawing.Point(300, 316);
            this.grbNoise.Name = "grbNoise";
            this.grbNoise.Size = new System.Drawing.Size(200, 58);
            this.grbNoise.TabIndex = 10;
            this.grbNoise.TabStop = false;
            this.grbNoise.Text = "Nhiễu";
            // 
            // txtWind
            // 
            this.txtWind.Enabled = false;
            this.txtWind.Location = new System.Drawing.Point(34, 32);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(100, 20);
            this.txtWind.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Vận tốc gió (m/s):";
            // 
            // UW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.grbNoise);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbLC);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UW";
            this.Text = "UW";
            this.Load += new System.EventHandler(this.UW_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbLC.ResumeLayout(false);
            this.grbLC.PerformLayout();
            this.grbNoise.ResumeLayout(false);
            this.grbNoise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbLangcan;
        private System.Windows.Forms.CheckBox ckbHapthu;
        private System.Windows.Forms.CheckBox ckbHinhhoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSalinity;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtpH;
        private System.Windows.Forms.TextBox txtDeep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbLC;
        private System.Windows.Forms.ComboBox cbxGround;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbNoise;
        private System.Windows.Forms.GroupBox grbNoise;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWind;
    }
}