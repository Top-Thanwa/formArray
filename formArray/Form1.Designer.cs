namespace formArray
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            lblCount = new Label();
            lblSum = new Label();
            lblAgv = new Label();
            lblMax = new Label();
            lblMin = new Label();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 86);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(225, 442);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(83, 45);
            label1.Name = "label1";
            label1.Size = new Size(113, 22);
            label1.TabIndex = 1;
            label1.Text = "กรอกข้อมูลตัวเลข";
            // 
            // button1
            // 
            button1.Location = new Point(341, 87);
            button1.Name = "button1";
            button1.Size = new Size(114, 58);
            button1.TabIndex = 2;
            button1.Text = "ประมวลผล";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.BackColor = SystemColors.ButtonFace;
            lblCount.BorderStyle = BorderStyle.FixedSingle;
            lblCount.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(491, 82);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(111, 30);
            lblCount.TabIndex = 3;
            lblCount.Text = "จำนวนข้อมูล";
            lblCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.BackColor = SystemColors.ButtonFace;
            lblSum.BorderStyle = BorderStyle.FixedSingle;
            lblSum.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(491, 125);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(66, 30);
            lblSum.TabIndex = 4;
            lblSum.Text = "ผลรวม";
            // 
            // lblAgv
            // 
            lblAgv.AutoSize = true;
            lblAgv.BackColor = SystemColors.ButtonFace;
            lblAgv.BorderStyle = BorderStyle.FixedSingle;
            lblAgv.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgv.Location = new Point(491, 165);
            lblAgv.Name = "lblAgv";
            lblAgv.Size = new Size(73, 30);
            lblAgv.TabIndex = 5;
            lblAgv.Text = "ค่าเฉลี่ย";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.BackColor = SystemColors.ButtonFace;
            lblMax.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMax.Location = new Point(491, 204);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(75, 28);
            lblMax.TabIndex = 6;
            lblMax.Text = "ค่าสูงสุด";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.BackColor = SystemColors.ButtonFace;
            lblMin.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMin.Location = new Point(491, 245);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(77, 28);
            lblMin.TabIndex = 7;
            lblMin.Text = "ค่าต่ำสุด";
            // 
            // button2
            // 
            button2.Location = new Point(663, 96);
            button2.Name = "button2";
            button2.Size = new Size(151, 49);
            button2.TabIndex = 8;
            button2.Text = "ทดสอบ array 2 มิติ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(663, 165);
            label2.Name = "label2";
            label2.Size = new Size(377, 202);
            label2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1078, 576);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(lblAgv);
            Controls.Add(lblSum);
            Controls.Add(lblCount);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label lblCount;
        private Label lblSum;
        private Label lblAgv;
        private Label lblMax;
        private Label lblMin;
        private Button button2;
        private Label label2;
    }
}
