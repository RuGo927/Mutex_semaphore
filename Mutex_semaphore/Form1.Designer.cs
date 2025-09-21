namespace Mutex_semaphore
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(64, 64, 64);
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listBox1.ForeColor = Color.FromArgb(128, 255, 128);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 199);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(64, 64, 64);
            listBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listBox2.ForeColor = Color.Red;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(263, 27);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(218, 199);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(64, 64, 64);
            listBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox3.ForeColor = Color.White;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(516, 27);
            listBox3.Name = "CreateThreadList";
            listBox3.Size = new Size(218, 199);
            listBox3.TabIndex = 2;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 3;
            label1.Text = "Working Threads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(263, 4);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 4;
            label2.Text = "Waiting Threads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(516, 4);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Created Threads";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 229);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "Place in Semaphore";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.Info;
            numericUpDown1.Font = new Font("Segoe UI", 11F);
            numericUpDown1.Location = new Point(12, 247);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(111, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(620, 235);
            button2.Name = "button2";
            button2.Size = new Size(116, 38);
            button2.TabIndex = 8;
            button2.Text = "Create New";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 51, 51);
            ClientSize = new Size(744, 291);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Threads & Semaphore";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Button button2;
    }
}
