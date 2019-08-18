namespace Radik
{
    partial class settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_label = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.generator = new System.Windows.Forms.TextBox();
            this.analyzer = new System.Windows.Forms.TextBox();
            this.oscilloscope = new System.Windows.Forms.TextBox();
            this.freqcounter = new System.Windows.Forms.TextBox();
            this.powersuply = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.microcontroller = new System.Windows.Forms.ComboBox();
            this.gdm = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.generator2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.exit_but);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 32);
            this.panel1.TabIndex = 1;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(10, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(116, 13);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Настройка устройств";
            this.name_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.name_label_MouseMove);
            // 
            // exit_but
            // 
            this.exit_but.BackColor = System.Drawing.Color.White;
            this.exit_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_but.FlatAppearance.BorderSize = 0;
            this.exit_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_but.ForeColor = System.Drawing.Color.Black;
            this.exit_but.Location = new System.Drawing.Point(265, 4);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(21, 23);
            this.exit_but.TabIndex = 0;
            this.exit_but.Text = "X";
            this.exit_but.UseVisualStyleBackColor = false;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Источник питания";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Опорный генератор";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Анализатор спектра";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Осцилограф";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Частотомер";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Мультиметр";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // generator
            // 
            this.generator.Location = new System.Drawing.Point(137, 85);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(134, 20);
            this.generator.TabIndex = 9;
            this.generator.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // analyzer
            // 
            this.analyzer.Location = new System.Drawing.Point(137, 115);
            this.analyzer.Name = "analyzer";
            this.analyzer.Size = new System.Drawing.Size(134, 20);
            this.analyzer.TabIndex = 10;
            this.analyzer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // oscilloscope
            // 
            this.oscilloscope.Location = new System.Drawing.Point(137, 147);
            this.oscilloscope.Name = "oscilloscope";
            this.oscilloscope.Size = new System.Drawing.Size(134, 20);
            this.oscilloscope.TabIndex = 11;
            this.oscilloscope.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // freqcounter
            // 
            this.freqcounter.Location = new System.Drawing.Point(137, 175);
            this.freqcounter.Name = "freqcounter";
            this.freqcounter.Size = new System.Drawing.Size(134, 20);
            this.freqcounter.TabIndex = 12;
            this.freqcounter.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // powersuply
            // 
            this.powersuply.FormattingEnabled = true;
            this.powersuply.Location = new System.Drawing.Point(137, 57);
            this.powersuply.Name = "powersuply";
            this.powersuply.Size = new System.Drawing.Size(134, 21);
            this.powersuply.TabIndex = 15;
            this.powersuply.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(207, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Микросхема";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // microcontroller
            // 
            this.microcontroller.FormattingEnabled = true;
            this.microcontroller.Location = new System.Drawing.Point(137, 237);
            this.microcontroller.Name = "microcontroller";
            this.microcontroller.Size = new System.Drawing.Size(134, 21);
            this.microcontroller.TabIndex = 17;
            // 
            // gdm
            // 
            this.gdm.FormattingEnabled = true;
            this.gdm.Location = new System.Drawing.Point(137, 206);
            this.gdm.Name = "gdm";
            this.gdm.Size = new System.Drawing.Size(134, 21);
            this.gdm.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Генератор 2";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // generator2
            // 
            this.generator2.Location = new System.Drawing.Point(137, 268);
            this.generator2.Name = "generator2";
            this.generator2.Size = new System.Drawing.Size(134, 20);
            this.generator2.TabIndex = 21;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 341);
            this.Controls.Add(this.generator2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gdm);
            this.Controls.Add(this.microcontroller);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.powersuply);
            this.Controls.Add(this.freqcounter);
            this.Controls.Add(this.oscilloscope);
            this.Controls.Add(this.analyzer);
            this.Controls.Add(this.generator);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox generator;
        private System.Windows.Forms.TextBox analyzer;
        private System.Windows.Forms.TextBox oscilloscope;
        private System.Windows.Forms.TextBox freqcounter;
        private System.Windows.Forms.ComboBox powersuply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox microcontroller;
        private System.Windows.Forms.ComboBox gdm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox generator2;
    }
}