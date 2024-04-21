namespace ConvolutionalCode
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            button3 = new Button();
            cbAvailablePolynoms = new ComboBox();
            textBox3 = new RichTextBox();
            textBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(763, 89);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 1;
            label1.Text = "Информационное сообщение";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(681, 187);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Найти...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 330);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 5;
            label2.Text = "Свёрточный код";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(305, 744);
            button1.Name = "button1";
            button1.Size = new Size(159, 40);
            button1.TabIndex = 6;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(264, 20);
            label3.TabIndex = 8;
            label3.Text = "Информационное сообщение в 2СС";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(12, 454);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 9;
            label4.Text = "Вероятность ошибки:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDown1.Location = new Point(196, 452);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(143, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(12, 499);
            label5.Name = "label5";
            label5.Size = new Size(288, 20);
            label5.TabIndex = 12;
            label5.Text = "Свёрточный код, пришедший по каналу";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Location = new Point(12, 522);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(763, 89);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox2.BackColor = SystemColors.Window;
            richTextBox2.Location = new Point(12, 645);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox2.Size = new Size(763, 84);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(12, 622);
            label6.Name = "label6";
            label6.Size = new Size(213, 20);
            label6.TabIndex = 14;
            label6.Text = "Декодированное сообщение";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 29);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 17;
            label7.Text = "Полиномы в 8СС:";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(455, 187);
            button3.Name = "button3";
            button3.Size = new Size(220, 29);
            button3.TabIndex = 18;
            button3.Text = "В текстовам виде";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cbAvailablePolynoms
            // 
            cbAvailablePolynoms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbAvailablePolynoms.BackColor = SystemColors.Window;
            cbAvailablePolynoms.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAvailablePolynoms.FlatStyle = FlatStyle.System;
            cbAvailablePolynoms.FormattingEnabled = true;
            cbAvailablePolynoms.Location = new Point(153, 26);
            cbAvailablePolynoms.Name = "cbAvailablePolynoms";
            cbAvailablePolynoms.Size = new Size(622, 28);
            cbAvailablePolynoms.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = SystemColors.Window;
            textBox3.Location = new Point(12, 230);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = RichTextBoxScrollBars.Vertical;
            textBox3.Size = new Size(763, 97);
            textBox3.TabIndex = 20;
            textBox3.Text = "";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(12, 353);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = RichTextBoxScrollBars.Vertical;
            textBox2.Size = new Size(763, 98);
            textBox2.TabIndex = 21;
            textBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 796);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(cbAvailablePolynoms);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(richTextBox2);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label6;
        private Label label7;
        private ToolTip toolTip1;
        private Button button3;
        private ComboBox cbAvailablePolynoms;
        private RichTextBox textBox3;
        private RichTextBox textBox2;
    }
}
