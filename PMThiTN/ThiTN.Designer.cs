namespace PMThiTN
{
    partial class ThiTN
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
            this.ndQuestion = new System.Windows.Forms.GroupBox();
            this.noidungCauhoi = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.D4 = new System.Windows.Forms.RichTextBox();
            this.D3 = new System.Windows.Forms.RichTextBox();
            this.D2 = new System.Windows.Forms.RichTextBox();
            this.D1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MaDeThi = new System.Windows.Forms.TextBox();
            this.txtDeThi = new System.Windows.Forms.Label();
            this.ns = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ndQuestion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ndQuestion
            // 
            this.ndQuestion.Controls.Add(this.noidungCauhoi);
            this.ndQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ndQuestion.Location = new System.Drawing.Point(47, 45);
            this.ndQuestion.Name = "ndQuestion";
            this.ndQuestion.Size = new System.Drawing.Size(533, 269);
            this.ndQuestion.TabIndex = 0;
            this.ndQuestion.TabStop = false;
            this.ndQuestion.Text = "Nội dung câu hỏi";
            this.ndQuestion.Enter += new System.EventHandler(this.ndQuestion_Enter);
            // 
            // noidungCauhoi
            // 
            this.noidungCauhoi.Location = new System.Drawing.Point(5, 38);
            this.noidungCauhoi.Name = "noidungCauhoi";
            this.noidungCauhoi.ReadOnly = true;
            this.noidungCauhoi.Size = new System.Drawing.Size(522, 220);
            this.noidungCauhoi.TabIndex = 0;
            this.noidungCauhoi.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.D4);
            this.groupBox1.Controls.Add(this.D3);
            this.groupBox1.Controls.Add(this.D2);
            this.groupBox1.Controls.Add(this.D1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(47, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn đáp án đúng";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(13, 348);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(93, 25);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "D";
            this.radioButton4.Text = "Đáp án D";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(13, 251);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 25);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "C";
            this.radioButton3.Text = "Đáp án C";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(13, 146);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 25);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "B";
            this.radioButton2.Text = "Đáp án B";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(13, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 25);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "A";
            this.radioButton1.Text = "Đáp án A";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // D4
            // 
            this.D4.Location = new System.Drawing.Point(13, 379);
            this.D4.Name = "D4";
            this.D4.ReadOnly = true;
            this.D4.Size = new System.Drawing.Size(506, 53);
            this.D4.TabIndex = 3;
            this.D4.Text = "";
            // 
            // D3
            // 
            this.D3.Location = new System.Drawing.Point(13, 282);
            this.D3.Name = "D3";
            this.D3.ReadOnly = true;
            this.D3.Size = new System.Drawing.Size(506, 53);
            this.D3.TabIndex = 2;
            this.D3.Text = "";
            // 
            // D2
            // 
            this.D2.Location = new System.Drawing.Point(13, 177);
            this.D2.Name = "D2";
            this.D2.ReadOnly = true;
            this.D2.Size = new System.Drawing.Size(506, 53);
            this.D2.TabIndex = 1;
            this.D2.Text = "";
            this.D2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(13, 72);
            this.D1.Name = "D1";
            this.D1.ReadOnly = true;
            this.D1.Size = new System.Drawing.Size(506, 53);
            this.D1.TabIndex = 0;
            this.D1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MaDeThi);
            this.groupBox2.Controls.Add(this.txtDeThi);
            this.groupBox2.Controls.Add(this.ns);
            this.groupBox2.Controls.Add(this.sex);
            this.groupBox2.Controls.Add(this.boxName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(612, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 307);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thí sinh";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // MaDeThi
            // 
            this.MaDeThi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaDeThi.Location = new System.Drawing.Point(188, 240);
            this.MaDeThi.Name = "MaDeThi";
            this.MaDeThi.ReadOnly = true;
            this.MaDeThi.Size = new System.Drawing.Size(290, 28);
            this.MaDeThi.TabIndex = 8;
            // 
            // txtDeThi
            // 
            this.txtDeThi.AutoSize = true;
            this.txtDeThi.Font = new System.Drawing.Font("#9Slide03 Helve", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtDeThi.Location = new System.Drawing.Point(19, 240);
            this.txtDeThi.Name = "txtDeThi";
            this.txtDeThi.Size = new System.Drawing.Size(95, 29);
            this.txtDeThi.TabIndex = 7;
            this.txtDeThi.Text = "Mã Đề:  ";
            // 
            // ns
            // 
            this.ns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ns.Location = new System.Drawing.Point(188, 120);
            this.ns.Name = "ns";
            this.ns.ReadOnly = true;
            this.ns.Size = new System.Drawing.Size(290, 28);
            this.ns.TabIndex = 6;
            this.ns.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sex
            // 
            this.sex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sex.Location = new System.Drawing.Point(188, 182);
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Size = new System.Drawing.Size(290, 28);
            this.sex.TabIndex = 5;
            // 
            // boxName
            // 
            this.boxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxName.Location = new System.Drawing.Point(188, 61);
            this.boxName.Name = "boxName";
            this.boxName.ReadOnly = true;
            this.boxName.Size = new System.Drawing.Size(290, 28);
            this.boxName.TabIndex = 3;
            this.boxName.TextChanged += new System.EventHandler(this.boxName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 Helve", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Helve", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Helve", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuit);
            this.groupBox3.Controls.Add(this.btnPre);
            this.groupBox3.Controls.Add(this.btnFinish);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(611, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 188);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(296, 113);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 43);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPre.Location = new System.Drawing.Point(79, 48);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(126, 43);
            this.btnPre.TabIndex = 2;
            this.btnPre.Text = "Câu Trước";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.Location = new System.Drawing.Point(79, 122);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(126, 43);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Nộp Bài";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(296, 48);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 43);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Câu Tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 661);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // ThiTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 804);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ndQuestion);
            this.Name = "ThiTN";
            this.Text = "ThiTN";
            this.Load += new System.EventHandler(this.ThiTN_Load);
            this.ndQuestion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox ndQuestion;
        private RichTextBox noidungCauhoi;
        private GroupBox groupBox1;
        private RichTextBox D4;
        private RichTextBox D3;
        private RichTextBox D2;
        private RichTextBox D1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnQuit;
        private Button btnPre;
        private Button btnFinish;
        private Button btnNext;
        private TextBox boxName;
        private TextBox ns;
        private TextBox sex;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label txtDeThi;
        private TextBox MaDeThi;
        private Label label4;
    }
}