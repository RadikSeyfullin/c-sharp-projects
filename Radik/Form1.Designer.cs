namespace Radik
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_label = new System.Windows.Forms.Label();
            this.roll_but = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.auto_mode = new System.Windows.Forms.Button();
            this.auto_hand_mode = new System.Windows.Forms.Button();
            this.hand_mode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.help_but = new System.Windows.Forms.Button();
            this.start_but = new System.Windows.Forms.Button();
            this.point_choose = new System.Windows.Forms.ComboBox();
            this.point_choose_label = new System.Windows.Forms.Label();
            this.settings_but = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.roll_but);
            this.panel1.Controls.Add(this.exit_but);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(10, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(264, 13);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Тестирование микросхемы дробного синтезатора";
            this.name_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.name_label_MouseMove);
            // 
            // roll_but
            // 
            this.roll_but.BackColor = System.Drawing.Color.White;
            this.roll_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roll_but.FlatAppearance.BorderSize = 0;
            this.roll_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roll_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll_but.ForeColor = System.Drawing.Color.Black;
            this.roll_but.Location = new System.Drawing.Point(539, 4);
            this.roll_but.Name = "roll_but";
            this.roll_but.Size = new System.Drawing.Size(21, 23);
            this.roll_but.TabIndex = 1;
            this.roll_but.Text = "_";
            this.roll_but.UseVisualStyleBackColor = false;
            this.roll_but.Click += new System.EventHandler(this.roll_but_Click);
            // 
            // exit_but
            // 
            this.exit_but.BackColor = System.Drawing.Color.White;
            this.exit_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_but.FlatAppearance.BorderSize = 0;
            this.exit_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_but.ForeColor = System.Drawing.Color.Black;
            this.exit_but.Location = new System.Drawing.Point(566, 4);
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
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор режима работы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // auto_mode
            // 
            this.auto_mode.BackColor = System.Drawing.Color.White;
            this.auto_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auto_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto_mode.Location = new System.Drawing.Point(0, 62);
            this.auto_mode.Name = "auto_mode";
            this.auto_mode.Size = new System.Drawing.Size(194, 39);
            this.auto_mode.TabIndex = 2;
            this.auto_mode.Text = "Автоматический";
            this.auto_mode.UseVisualStyleBackColor = false;
            this.auto_mode.Click += new System.EventHandler(this.auto_mode_Click);
            // 
            // auto_hand_mode
            // 
            this.auto_hand_mode.BackColor = System.Drawing.Color.White;
            this.auto_hand_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auto_hand_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto_hand_mode.Location = new System.Drawing.Point(193, 62);
            this.auto_hand_mode.Name = "auto_hand_mode";
            this.auto_hand_mode.Size = new System.Drawing.Size(210, 39);
            this.auto_hand_mode.TabIndex = 3;
            this.auto_hand_mode.Text = "Выборочный";
            this.auto_hand_mode.UseVisualStyleBackColor = false;
            this.auto_hand_mode.Click += new System.EventHandler(this.auto_hand_mode_Click);
            // 
            // hand_mode
            // 
            this.hand_mode.BackColor = System.Drawing.Color.White;
            this.hand_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hand_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hand_mode.Location = new System.Drawing.Point(401, 62);
            this.hand_mode.Name = "hand_mode";
            this.hand_mode.Size = new System.Drawing.Size(198, 39);
            this.hand_mode.TabIndex = 4;
            this.hand_mode.Text = "Пошаговый";
            this.hand_mode.UseVisualStyleBackColor = false;
            this.hand_mode.Click += new System.EventHandler(this.hand_mode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результаты";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // help_but
            // 
            this.help_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.help_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_but.FlatAppearance.BorderSize = 0;
            this.help_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_but.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_but.ForeColor = System.Drawing.Color.White;
            this.help_but.Location = new System.Drawing.Point(372, 317);
            this.help_but.Name = "help_but";
            this.help_but.Size = new System.Drawing.Size(38, 39);
            this.help_but.TabIndex = 7;
            this.help_but.Text = " ?";
            this.help_but.UseVisualStyleBackColor = false;
            this.help_but.Click += new System.EventHandler(this.help_but_Click);
            // 
            // start_but
            // 
            this.start_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_but.Enabled = false;
            this.start_but.FlatAppearance.BorderSize = 0;
            this.start_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_but.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_but.ForeColor = System.Drawing.Color.White;
            this.start_but.Location = new System.Drawing.Point(372, 258);
            this.start_but.Name = "start_but";
            this.start_but.Size = new System.Drawing.Size(216, 56);
            this.start_but.TabIndex = 8;
            this.start_but.Text = "Запустить";
            this.start_but.UseVisualStyleBackColor = false;
            this.start_but.Click += new System.EventHandler(this.start_but_Click);
            // 
            // point_choose
            // 
            this.point_choose.DropDownHeight = 450;
            this.point_choose.DropDownWidth = 750;
            this.point_choose.FormattingEnabled = true;
            this.point_choose.IntegralHeight = false;
            this.point_choose.ItemHeight = 13;
            this.point_choose.Items.AddRange(new object[] {
            "1. Max выходная частота синтезатора",
            "2. Min выходная частота синтезатора",
            "3. Max мощность сигнала на выходе синтезатора",
            "4. Min мощность сигнала на выходе синетазтора",
            "5. Мощность сигнала на выходе синтезатора при отключении выхода",
            "6. Max опорная частота",
            "7. Max частота сравнения",
            "8. Min шаг перестройки частоты выходного сигнала синтезатора в режиме целочисленн" +
                "ого деления",
            "9. Min шаг перестройки частоты выходного сигнала синтезатора в режиме дробного де" +
                "ления",
            "10. Уровень фазовых шумов выходного сигнала синтезатора на частоте 2 ГГц при отст" +
                "ройке 100 кГц",
            "11. Уровень фазовых шумов выходного сигнала синтезатора на частоте 2 ГГц при отст" +
                "ройке 1 МГц",
            "12. Уровень фазовых шумов выходного сигнала синтезатора на частоте 1 ГГц при отст" +
                "ройке 100 кГц",
            "13. Уровень фазовых шумов выходного сигнала синтезатора на частоте 1 ГГц при отст" +
                "ройке 1 МГц",
            "14. Уровень приведённых фазовых шумов ФАПЧ",
            "15. Ток потребления при максимальной мощности выходного сигнала",
            "16. Ток потребления при минимальной мощности выходного сигнала",
            "17. Ток потребления в \"спящем\" режиме",
            "18. Max выходной ток токового ключа",
            "19. Min выходной ток токового ключа",
            "20. Min шаг дискретной регулировки выходного тока токового ключа",
            "21. Ток утечки токового ключа в третьем состоянии",
            "22. Max относительное рассоглосование токов в плечах токового ключа",
            "23. Max относительное изменение выходного тока токового ключа в диапазоне выходны" +
                "х напряжений",
            "24. Max относительное изменение выходного тока токового ключа в диапазоне темпера" +
                "тур",
            "25. Относительная точность установки тока токового ключа",
            "26. Ток утечки по входу (для цифровых входов)",
            "27. Выходной ток низкого уровня цифровых выходов",
            "28. Выходной ток высокого уровня цифровых выходов",
            "29. Max тактовая частота последовательного интерфейса",
            "30. Относительный уровень паразитных составляющих в спектре выходного сигнала на " +
                "отстройках от несущей, кратных частоте сравнения",
            "31. Относительный уровень второй гармоники в спектре выходного сигнала частотой 2" +
                " ГГц",
            "32. Относительный уровень третьей гармоники в спектре выходного сигнала частотой " +
                "2 ГГц",
            "33. Относительный уровень четвёртой гармоники в спектре выходного сигнала частото" +
                "й 2 ГГц"});
            this.point_choose.Location = new System.Drawing.Point(12, 132);
            this.point_choose.Name = "point_choose";
            this.point_choose.Size = new System.Drawing.Size(575, 21);
            this.point_choose.TabIndex = 9;
            this.point_choose.SelectedIndexChanged += new System.EventHandler(this.point_choose_SelectedIndexChanged);
            // 
            // point_choose_label
            // 
            this.point_choose_label.AutoSize = true;
            this.point_choose_label.Location = new System.Drawing.Point(15, 116);
            this.point_choose_label.Name = "point_choose_label";
            this.point_choose_label.Size = new System.Drawing.Size(77, 13);
            this.point_choose_label.TabIndex = 10;
            this.point_choose_label.Text = "Выбор пункта";
            // 
            // settings_but
            // 
            this.settings_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settings_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_but.FlatAppearance.BorderSize = 0;
            this.settings_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_but.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings_but.ForeColor = System.Drawing.Color.White;
            this.settings_but.Location = new System.Drawing.Point(416, 317);
            this.settings_but.Name = "settings_but";
            this.settings_but.Size = new System.Drawing.Size(171, 39);
            this.settings_but.TabIndex = 11;
            this.settings_but.Text = "Настройка устройств";
            this.settings_but.UseVisualStyleBackColor = false;
            this.settings_but.Click += new System.EventHandler(this.settings_but_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.ForeColor = System.Drawing.Color.Green;
            this.richTextBox1.Location = new System.Drawing.Point(13, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(353, 181);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(599, 367);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.settings_but);
            this.Controls.Add(this.point_choose_label);
            this.Controls.Add(this.point_choose);
            this.Controls.Add(this.start_but);
            this.Controls.Add(this.help_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hand_mode);
            this.Controls.Add(this.auto_hand_mode);
            this.Controls.Add(this.auto_mode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button roll_but;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button auto_mode;
        private System.Windows.Forms.Button auto_hand_mode;
        private System.Windows.Forms.Button hand_mode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button help_but;
        private System.Windows.Forms.Button start_but;
        private System.Windows.Forms.ComboBox point_choose;
        private System.Windows.Forms.Label point_choose_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button settings_but;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

