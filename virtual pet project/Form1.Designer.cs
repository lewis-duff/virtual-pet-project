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
            foodButton = new Button();
            thirstButton = new Button();
            sleepButton = new Button();
            CatPicture = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            sleepDecreaseBox = new PictureBox();
            thirstDecreaseBox = new PictureBox();
            foodDecreaseBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CatPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sleepDecreaseBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thirstDecreaseBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodDecreaseBox).BeginInit();
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
            // foodButton
            // 
            foodButton.BackColor = Color.Red;
            foodButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            foodButton.ForeColor = SystemColors.ButtonFace;
            foodButton.Location = new Point(99, 335);
            foodButton.Margin = new Padding(3, 3, 45, 3);
            foodButton.Name = "foodButton";
            foodButton.Size = new Size(203, 96);
            foodButton.TabIndex = 3;
            foodButton.Text = "Food";
            foodButton.UseVisualStyleBackColor = false;
            foodButton.Click += foodButton_Click;
            // 
            // thirstButton
            // 
            thirstButton.BackColor = Color.Blue;
            thirstButton.FlatAppearance.BorderColor = Color.Black;
            thirstButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            thirstButton.ForeColor = SystemColors.ButtonFace;
            thirstButton.Location = new Point(350, 335);
            thirstButton.Name = "thirstButton";
            thirstButton.Size = new Size(203, 96);
            thirstButton.TabIndex = 4;
            thirstButton.Text = "Thirst";
            thirstButton.UseVisualStyleBackColor = false;
            // 
            // sleepButton
            // 
            sleepButton.BackColor = Color.Lime;
            sleepButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            sleepButton.ForeColor = SystemColors.ControlText;
            sleepButton.Location = new Point(602, 335);
            sleepButton.Margin = new Padding(46, 3, 3, 3);
            sleepButton.Name = "sleepButton";
            sleepButton.Size = new Size(203, 96);
            sleepButton.TabIndex = 5;
            sleepButton.Text = "Sleep";
            sleepButton.UseVisualStyleBackColor = false;
            // 
            // CatPicture
            // 
            CatPicture.Location = new Point(99, 12);
            CatPicture.Name = "CatPicture";
            CatPicture.Size = new Size(706, 300);
            CatPicture.TabIndex = 6;
            CatPicture.TabStop = false;
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
            // sleepDecreaseBox
            // 
            sleepDecreaseBox.BackColor = SystemColors.Desktop;
            sleepDecreaseBox.Location = new Point(64, 12);
            sleepDecreaseBox.Name = "sleepDecreaseBox";
            sleepDecreaseBox.Size = new Size(20, 100);
            sleepDecreaseBox.TabIndex = 9;
            sleepDecreaseBox.TabStop = false;
            // 
            // thirstDecreaseBox
            // 
            thirstDecreaseBox.BackColor = SystemColors.Desktop;
            thirstDecreaseBox.Location = new Point(38, 12);
            thirstDecreaseBox.Name = "thirstDecreaseBox";
            thirstDecreaseBox.Size = new Size(20, 300);
            thirstDecreaseBox.TabIndex = 10;
            thirstDecreaseBox.TabStop = false;
            // 
            // foodDecreaseBox
            // 
            foodDecreaseBox.BackColor = SystemColors.Desktop;
            foodDecreaseBox.Location = new Point(12, 12);
            foodDecreaseBox.Name = "foodDecreaseBox";
            foodDecreaseBox.Size = new Size(20, 300);
            foodDecreaseBox.TabIndex = 11;
            foodDecreaseBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 464);
            Controls.Add(foodDecreaseBox);
            Controls.Add(thirstDecreaseBox);
            Controls.Add(sleepDecreaseBox);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(CatPicture);
            Controls.Add(sleepButton);
            Controls.Add(thirstButton);
            Controls.Add(foodButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)CatPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)sleepDecreaseBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)thirstDecreaseBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodDecreaseBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button foodButton;
        private Button thirstButton;
        private Button sleepButton;
        private PictureBox CatPicture;
        private Label label1;
        private TextBox textBox1;
        private PictureBox sleepDecreaseBox;
        private PictureBox thirstDecreaseBox;
        private PictureBox foodDecreaseBox;
    }
}
