namespace Activity_02
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            label3 = new Label();
            radioButton2 = new RadioButton();
            label4 = new Label();
            button1 = new Button();
            checkBox4 = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(350, 20);
            comboBox1.Margin = new Padding(5, 4, 5, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 29);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 24);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Pizza Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 15);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 2;
            label2.Text = "Toppings";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(68, 102);
            checkBox2.Margin = new Padding(5, 4, 5, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(106, 25);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Pepproni";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(68, 137);
            checkBox3.Margin = new Padding(5, 4, 5, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(130, 25);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Mushrooms";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(68, 58);
            radioButton1.Margin = new Padding(5, 4, 5, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 25);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Thin";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 15);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 7;
            label3.Text = "Crust Type";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(193, 58);
            radioButton2.Margin = new Padding(5, 4, 5, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 25);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Thick";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 412);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 9;
            label4.Text = "Toppings";
            label4.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(270, 361);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(159, 36);
            button1.TabIndex = 10;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(68, 66);
            checkBox4.Margin = new Padding(5, 4, 5, 4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(95, 25);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "Cheese";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox3);
            panel1.Location = new Point(187, 57);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 182);
            panel1.TabIndex = 12;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Location = new Point(187, 247);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 106);
            panel2.TabIndex = 13;
            panel2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 629);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizza Order Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton radioButton1;
        private Label label3;
        private RadioButton radioButton2;
        private Label label4;
        private Button button1;
        private CheckBox checkBox4;
        private Panel panel1;
        private Panel panel2;
    }
}