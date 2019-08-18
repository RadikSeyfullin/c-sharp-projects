namespace Radik
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            this.name_label = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(10, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(50, 13);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Справка";
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
            this.exit_but.Location = new System.Drawing.Point(579, 4);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(21, 23);
            this.exit_but.TabIndex = 0;
            this.exit_but.Text = "X";
            this.exit_but.UseVisualStyleBackColor = false;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.exit_but);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 32);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 455);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "help";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}