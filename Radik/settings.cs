using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace Radik
{
    public partial class settings : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public settings()
        {
            InitializeComponent();
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

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("database.xml");

            XmlNode powersuplynode = xd.SelectSingleNode("//setting[name = 'powersuply']/set");
            powersuplynode.InnerText = powersuply.Text;

            XmlNode generatornode = xd.SelectSingleNode("//setting[name = 'generator']/set");
            generatornode.InnerText = generator.Text;

            XmlNode analyzernode = xd.SelectSingleNode("//setting[name = 'analyzer']/set");
            analyzernode.InnerText = analyzer.Text;

            XmlNode oscilloscopenode = xd.SelectSingleNode("//setting[name = 'oscilloscope']/set");
            oscilloscopenode.InnerText = oscilloscope.Text;

            XmlNode freqcounternode = xd.SelectSingleNode("//setting[name = 'freqcounter']/set");
            freqcounternode.InnerText = freqcounter.Text;

            XmlNode gdmnode = xd.SelectSingleNode("//setting[name = 'gdm']/set");
            gdmnode.InnerText = gdm.Text;

            XmlNode microcontrollernode = xd.SelectSingleNode("//setting[name = 'microcontroller']/set");
            microcontrollernode.InnerText = microcontroller.Text;

            XmlNode generator2node = xd.SelectSingleNode("//setting[name = 'generator2']/set");
            generator2node.InnerText = generator2.Text;

            xd.Save("database.xml");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {
            String xmlString = File.ReadAllText("database.xml");
            XDocument xdoc = XDocument.Load(new StringReader(xmlString));
            var xmllist = (from setting in xdoc.Descendants("setting")
                           select new
                           {
                               name = setting.Descendants("name").SingleOrDefault(),
                               set = setting.Descendants("set").SingleOrDefault()
                           }
                           ).ToList();

            var itemlist = (from item in xmllist
                            select new
                            {
                                name = item.name.Value,
                                set = item.set.Value
                            }
                            );

            foreach (var item in itemlist)
            {
                switch (item.name)
                {
                    case "powersuply":
                        {
                            powersuply.Text = item.set;
                            break;
                        }
                    case "generator":
                        {
                            generator.Text = item.set;
                            break;
                        }
                    case "analyzer":
                        {
                            analyzer.Text = item.set;
                            break;
                        }
                    case "oscilloscope":
                        {
                            oscilloscope.Text = item.set;
                            break;
                        }
                    case "freqcounter":
                        {
                            freqcounter.Text = item.set;
                            break;
                        }
                    case "gdm":
                        {
                            gdm.Text = item.set;
                            break;
                        }
                    case "microcontroller":
                        {
                            microcontroller.Text = item.set;
                            break;
                        }
                    case "generator2":
                        {
                            generator2.Text = item.set;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
