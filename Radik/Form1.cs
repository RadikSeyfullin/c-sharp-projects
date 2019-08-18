using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace Radik
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        bool auto = false;
        bool auto_hand = false;
        bool hand = false;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        public void reset_other_buttons(Button first, Button second)
        {
            first.BackColor = Color.White;
            first.ForeColor = Color.Black;
            second.BackColor = Color.White;
            second.ForeColor = Color.Black;
        }

        private void start_but_Click(object sender, EventArgs e)
        {
            settings_but.Enabled = false;
            start_but.Enabled = false;
            richTextBox1.Clear();
            richTextBox1.Text += "Начало программы\n";
            connection conn = new connection();
            if (auto)
            {
                for (int i = 1; i <= 33; i++)
                {
                    if (i == 1)
                    {
                        StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Protokol.txt", true);
                        sw.WriteLine("---------------------------------------------------------------------------------");
                        sw.Close();
                    }
                    bool point = conn.main(i, richTextBox1, hand);
                    if (!point)
                    {
                        break;
                    }
                }
            }
            else if (auto_hand)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Protokol.txt", true);
                sw.WriteLine("---------------------------------------------------------------------------------");
                sw.Close();
                bool point = conn.main(point_choose.SelectedIndex + 1, richTextBox1, hand);
                
            }
            else if (hand)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Protokol.txt", true);
                sw.WriteLine("---------------------------------------------------------------------------------");
                sw.Close();
                bool point = conn.main(point_choose.SelectedIndex + 1, richTextBox1, hand);
            }
            settings_but.Enabled = true;
            
        }

        private void auto_mode_Click(object sender, EventArgs e)
        {
            start_but.Enabled = true;
            point_choose.Hide();
            point_choose_label.Hide();
            auto_mode.BackColor = Color.Gray;
            auto_mode.ForeColor = Color.White;
            reset_other_buttons(auto_hand_mode, hand_mode);
            auto = true;
            auto_hand = false;
            hand = false;
        }

        private void auto_hand_mode_Click(object sender, EventArgs e)
        {
            start_but.Enabled = true;
            point_choose.Show();
            point_choose_label.Show();
            auto_hand_mode.BackColor = Color.Gray;
            auto_hand_mode.ForeColor = Color.White;
            reset_other_buttons(auto_mode, hand_mode);
            auto_hand = true;
            auto = false;
            hand = false;
            if (point_choose.SelectedItem == null)
            {
                start_but.Enabled = false;
            }
        }

        private void hand_mode_Click(object sender, EventArgs e)
        {
            start_but.Enabled = true;
            point_choose.Show();
            point_choose_label.Show();
            hand_mode.BackColor = Color.Gray;
            hand_mode.ForeColor = Color.White;
            reset_other_buttons(auto_hand_mode, auto_mode);
            hand = true;
            auto_hand = false;
            auto = false;
            if (point_choose.SelectedItem == null)
            {
                start_but.Enabled = false;
            }
        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roll_but_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void name_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void settings_but_Click(object sender, EventArgs e)
        {
            settings set_page = new settings();
            set_page.ShowDialog();
        }

        private void help_but_Click(object sender, EventArgs e)
        {
            help help_page = new help();
            help_page.ShowDialog();
        }

        private void point_choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auto_hand || hand)
            {
                start_but.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            point_choose.Hide();
            point_choose_label.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
