namespace virtual_pet_project
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 300);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Blue;
            pictureBox2.Location = new Point(38, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(200, 0, 0, 0);
            pictureBox2.Size = new Size(20, 300);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Lime;
            pictureBox3.Location = new Point(64, 12);
            pictureBox3.Margin = new Padding(3, 3, 12, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 300);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(99, 335);
            button1.Margin = new Padding(3, 3, 45, 3);
            button1.Name = "button1";
            button1.Size = new Size(203, 96);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(350, 335);
            button2.Name = "button2";
            button2.Size = new Size(203, 96);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(602, 335);
            button3.Margin = new Padding(46, 3, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(203, 96);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(99, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(706, 300);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(825, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "PlaytIme";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(825, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 23);
            textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 464);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox4;
        private Label label1;
        private TextBox textBox1;
    }
}
