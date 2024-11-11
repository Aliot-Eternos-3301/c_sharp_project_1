namespace ПЗ__5_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox3 = new TextBox();
            label5 = new Label();
            calculate_button = new Button();
            clear_button = new Button();
            exit_button = new Button();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(45, 65);
            label1.Name = "label1";
            label1.Size = new Size(147, 29);
            label1.TabIndex = 0;
            label1.Text = "Значение a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(45, 102);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 1;
            label2.Text = "Значение b";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox1.Location = new Point(198, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 26);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox2.Location = new Point(199, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 26);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(45, 267);
            label3.Name = "label3";
            label3.Size = new Size(49, 29);
            label3.TabIndex = 4;
            label3.Text = "S =";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox4.Location = new Point(100, 271);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 26);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox3_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox5.Location = new Point(100, 307);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(212, 26);
            textBox5.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(45, 304);
            label4.Name = "label4";
            label4.Size = new Size(49, 29);
            label4.TabIndex = 6;
            label4.Text = "P =";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox3.Location = new Point(45, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 26);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(45, 172);
            label5.Name = "label5";
            label5.Size = new Size(261, 29);
            label5.TabIndex = 8;
            label5.Text = "Результат сложения:";
            // 
            // calculate_button
            // 
            calculate_button.BackColor = Color.Lime;
            calculate_button.Font = new Font("Microsoft Sans Serif", 12F);
            calculate_button.ForeColor = SystemColors.ActiveCaptionText;
            calculate_button.Location = new Point(44, 360);
            calculate_button.Name = "calculate_button";
            calculate_button.Size = new Size(172, 49);
            calculate_button.TabIndex = 10;
            calculate_button.Text = "Вычислить";
            calculate_button.UseVisualStyleBackColor = false;
            calculate_button.Click += calculate_button_Click;
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.Yellow;
            clear_button.Font = new Font("Microsoft Sans Serif", 12F);
            clear_button.Location = new Point(222, 360);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(172, 49);
            clear_button.TabIndex = 11;
            clear_button.Text = "Очистить";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += button2_Click;
            // 
            // exit_button
            // 
            exit_button.BackColor = Color.Red;
            exit_button.Font = new Font("Microsoft Sans Serif", 12F);
            exit_button.Location = new Point(126, 441);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(172, 49);
            exit_button.TabIndex = 12;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += exit_button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(12, 24);
            label6.Name = "label6";
            label6.Size = new Size(420, 29);
            label6.TabIndex = 13;
            label6.Text = "Вставьте числа в нижние два поля";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(341, 105);
            button2.Name = "button2";
            button2.Size = new Size(26, 26);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(341, 69);
            button3.Name = "button3";
            button3.Size = new Size(26, 26);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(441, 524);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(exit_button);
            Controls.Add(clear_button);
            Controls.Add(calculate_button);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ПЗ №5-6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox3;
        private Label label5;
        private Button calculate_button;
        private Button clear_button;
        private Button exit_button;
        private Label label6;
        private Button button2;
        private Button button3;
    }
}
