namespace CSLab05
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            btnPrevious = new Button();
            btnOpen = new Button();
            btnNext = new Button();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(548, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(37, 357);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<< Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(218, 357);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(143, 29);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Mở thư mục hình";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += button2_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(438, 357);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Sau >>";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(241, 404);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 445);
            Controls.Add(btnStart);
            Controls.Add(btnNext);
            Controls.Add(btnOpen);
            Controls.Add(btnPrevious);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Picture Slide Show";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPrevious;
        private Button btnOpen;
        private Button btnNext;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}