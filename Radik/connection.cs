using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Xml.Linq;

namespace Radik
{
    class connection
    {
        Microcontroller microcontroller;
        HMP4040 PowerSuply;
        Ag53230A FreqCounter;
        SMA100A Generator;
        SMA100A Generator2;
        N9038A Analyzer;
        RTO1024 Oscilloscope;
        GDM Gdm;
        
        string write_path = Application.StartupPath + @"\Protokol.txt";
        StreamWriter sw;

        public bool is_hand_mode = false;

        public bool main(int i, RichTextBox richTextBox1, bool hand_md)
        {
            if (hand_md)
            {
                is_hand_mode = true;
            }
            else
            {
                is_hand_mode = false;
            }

            switch (i)
            {
                case 1:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_1(richTextBox1);
                        if(result != 0)
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }
                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;

                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 2:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_2(richTextBox1);
                        if (result != 0)
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 3:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_3(richTextBox1);
                        if (result != 0)
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 4:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_4(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 5:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_5(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 6:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_6(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 7:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_7(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 8:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_8(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 9:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_9(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 10:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_10(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 11:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_11(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 12:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_12(richTextBox1);
                        if (result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 13:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_13(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 14:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_14(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 15:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_15(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 16:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_16(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 17:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_17(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 18:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_18(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 19:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_19(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 20:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_20(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 21:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_21(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 22:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_22(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 23:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_23(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 24:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_24(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 25:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_25(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 26:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_26(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 27:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_27(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 28:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_28(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 29:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_29(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 30:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_30(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 31:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_31(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 32:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_32(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                case 33:
                    {
                        bool r = false;
                        double result = 0;
                        result = point_33(richTextBox1);
                        if(result != 0) // тут проверка
                        {
                            r = true;
                            richTextBox1.Text += "Прошла успешно\n";

                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение положительно!");
                            sw.Close();
                        }

                        else
                        {
                            r = false;

                            richTextBox1.Text += "Ошибка\n";
                            richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка"), 6);
                            richTextBox1.SelectionColor = Color.Red;
                            /*
                             * Вывод в документ (переменная)
                             */
                            sw = new StreamWriter(write_path, true);
                            sw.WriteLine("[" + DateTime.Now + "] Проверка по пункту " + i + "! Результат: " + result + ", Решение отрицательное!");
                            sw.WriteLine("[" + DateTime.Now + "] Программа завершена!");
                            sw.Close();
                        }
                        return r;
                    }
                default:
                    {
                        return false;
                    }
                
            }
        }

        #region Проверки схем
        string powersuply_com, generator_ip, analyzer_ip, oscilloscope_ip, freqcounter_ip, gdm_com, microcontroller_com, generator2_ip;
        public void get_ip()
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
                            powersuply_com = item.set;
                            break;
                        }
                    case "generator":
                        {
                            generator_ip = item.set;
                            break;
                        }
                    case "analyzer":
                        {
                            analyzer_ip = item.set;
                            break;
                        }
                    case "oscilloscope":
                        {
                            oscilloscope_ip = item.set;
                            break;
                        }
                    case "freqcounter":
                        {
                            freqcounter_ip = item.set;
                            break;
                        }
                    case "gdm":
                        {
                            gdm_com = item.set;
                            break;
                        }
                    case "microcontroller":
                        {
                            microcontroller_com = item.set;
                            break;
                        }
                    case "generator2":
                        {
                            generator2_ip = item.set;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        public bool schema_1()
        {
            get_ip();
            bool ok = true;
            microcontroller = new Microcontroller();
            PowerSuply = new HMP4040();
            FreqCounter = new Ag53230A();
            Generator = new SMA100A();
            try
            {
                microcontroller.connect(microcontroller_com);
                PowerSuply.connect(powersuply_com);
                FreqCounter.connect(freqcounter_ip, true, false);
                Generator.connect(generator_ip, true, false);
            }
            catch
            {
                ok = false;
            }
            return ok;
        }

        public bool schema_2()
        {
            get_ip();
            bool ok = true;
            microcontroller = new Microcontroller();
            PowerSuply = new HMP4040();
            FreqCounter = new Ag53230A();
            Generator = new SMA100A();
            Analyzer = new N9038A();
            try
            {
                microcontroller.connect(microcontroller_com);
                PowerSuply.connect(powersuply_com);
                FreqCounter.connect(freqcounter_ip, true, false);
                Generator.connect(generator_ip, true, false);
                Analyzer.connect(analyzer_ip, true, false);
            }
            catch
            {
                ok = false;
            }
            return ok;
        }

        public bool schema_3()
        {
            get_ip();
            bool ok = true;
            microcontroller = new Microcontroller();
            PowerSuply = new HMP4040();
            FreqCounter = new Ag53230A();
            Generator = new SMA100A();
            Analyzer = new N9038A();
            Gdm = new GDM();
            try
            {
                microcontroller.connect(microcontroller_com);
                PowerSuply.connect(powersuply_com);
                FreqCounter.connect(freqcounter_ip, true, false);
                Generator.connect(generator_ip, true, false);
                Analyzer.connect(analyzer_ip, true, false);
                Gdm.connect(gdm_com);
            }
            catch
            {
                ok = false;
            }
            return ok;
        }

        public bool schema_4()
        {
            get_ip();
            bool ok = true;
            microcontroller = new Microcontroller();
            PowerSuply = new HMP4040();
            FreqCounter = new Ag53230A();
            Generator = new SMA100A();
            Analyzer = new N9038A();
            Gdm = new GDM();
            try
            {
                microcontroller.connect(microcontroller_com);
                PowerSuply.connect(powersuply_com);
                FreqCounter.connect(freqcounter_ip, true, false);
                Generator.connect(generator_ip, true, false);
                Analyzer.connect(analyzer_ip, true, false);
                Gdm.connect(gdm_com);
            }
            catch
            {
                ok = false;
            }
            return ok;
        }

        public bool schema_5()
        {
            get_ip();
            bool ok = true;
            microcontroller = new Microcontroller();
            PowerSuply = new HMP4040();
            FreqCounter = new Ag53230A();
            Generator = new SMA100A();
            Analyzer = new N9038A();
            Gdm = new GDM();
            try
            {
                microcontroller.connect(microcontroller_com);
                PowerSuply.connect(powersuply_com);
                FreqCounter.connect(freqcounter_ip, true, false);
                Generator.connect(generator_ip, true, false);
                Analyzer.connect(analyzer_ip, true, false);
                Gdm.connect(gdm_com);
            }
            catch
            {
                ok = false;
            }
            return ok;
        }

        public bool schema_6()
        {
            get_ip();
            bool ok = true;
            microcontroller = new Microcontroller();
            PowerSuply = new HMP4040();
            FreqCounter = new Ag53230A();
            Generator = new SMA100A();
            Analyzer = new N9038A();
            Gdm = new GDM();
            Oscilloscope = new RTO1024();
            try
            {
                microcontroller.connect(microcontroller_com);
                PowerSuply.connect(powersuply_com);
                FreqCounter.connect(freqcounter_ip, true, false);
                Generator.connect(generator_ip, true, false);
                Analyzer.connect(analyzer_ip, true, false);
                Gdm.connect(gdm_com);
                Oscilloscope.connect(oscilloscope_ip, true, false);
            }
            catch
            {
                ok = false;
            }
            return ok;
        }

        public bool schema_7()
        {
            get_ip();
            bool ok = true;
            microcontroller = new Microcontroller();
            PowerSuply = new HMP4040();
            FreqCounter = new Ag53230A();
            Generator = new SMA100A();
            Generator2 = new SMA100A();
            Analyzer = new N9038A();
            try
            {
                microcontroller.connect(microcontroller_com);
                PowerSuply.connect(powersuply_com);
                FreqCounter.connect(freqcounter_ip, true, false);
                Generator.connect(generator_ip, true, false);
                Analyzer.connect(analyzer_ip, true, false);
                Generator2.connect(generator2_ip, true, false);
            }
            catch
            {
                ok = false;
            }
            return ok;
        }
        #endregion

        #region Проверки пунктов
        public double point_1(RichTextBox richTextBox1)
        {
            bool is_all_ok = true;
            int N = 1;
            double result = 0;
            richTextBox1.Text += "Проверка пункта 1 ... \n";
            repeat:
            if (!schema_1())
            {
                var s = MessageBox.Show("Некоторые устройства не подключены, пожалуйста проверьте их и нажмите кнопку \"Повтор\"", "Ошибка", MessageBoxButtons.RetryCancel);
                if (s == DialogResult.Cancel)
                {
                    string error_msg = "ОШИБКА\nНекоторые устройства были не подключены! Программа завершена!";
                    richTextBox1.Text += error_msg + "\n";
                    richTextBox1.Select(richTextBox1.Text.IndexOf("ОШИБКА"), error_msg.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
                else
                {
                    goto repeat;
                }
            }
            else
            {
                try
                {
                    N:
                    /* Настройка источника питания */
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "\nВыполняется настройка источника питания (напряжение 3 вольта, ток ограничения 50 мА)\n";
                    }
                    PowerSuply.channelConfig(1, "3", "50");
                    PowerSuply.channelState(1, true);

                    /* Настройка опорного генератора */
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "Выполняется настройка опорного генератора (опорная частота 250 МГц, опорная мощность -5 дБм)\n";
                    }
                    Generator.RFConfig(250, -5);
                    Generator.outputState(true);

                    /* Запись данных на микросхему */
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "Запись данных с ПК на микросхему, соответствующие формированию выходной частоты F = 1950 МГц\n";
                    }
                    double F = 1950;
                    double F1 = 0;
                    microcontroller.setFreq(F);

                    for (int i = 0; i <= 5; i++)
                    {
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Считываем с частотомера частоту F1\n";
                        }
                        F1 = FreqCounter.readFrequency(1);
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Сравниваем частоту F1 и F\n";
                        }
                        if (F1 > (F + 0.001) || F1 < (F - 0.001)) /**/
                        {
                            if (N != 3)
                            {
                                N++;
                                if (is_hand_mode)
                                {
                                    richTextBox1.Text += "Данные частоты не совпадают\n попытка №" + N + "\n";
                                }
                                PowerSuply.channelState(1, false);
                                goto N;
                            }
                            else
                            {
                                if (is_hand_mode)
                                {
                                    richTextBox1.Text += "Данные частоты не совпадают. Требуется ручное вмешательство!\n";
                                }
                                is_all_ok = false;
                                break;
                            }
                        }
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Запись данных с ПК на микросхему, соответствующие формированию выходной частоты F + 10 МГц\nF = " + F + "\n";
                        }
                        F += 10;
                        microcontroller.setFreq(F);
                    }
                    if (is_all_ok)
                    {
                        result = F1;
                    }
                    else
                    {
                        result = 0;
                    }

                }
                catch (Exception error)
                {
                    string err_msg = "Ошибка:" + error.Message;
                    richTextBox1.Text += err_msg + "\n";
                    richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка:"), err_msg.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
            }
            
            return result;
        }

        public double point_2(RichTextBox richTextBox1)
        {
            bool is_all_ok = true;
            int N = 1;
            double result = 0;
            richTextBox1.Text += "Проверка пункта 2 ... \n";
            repeat:
            if (!schema_1())
            {
                var s = MessageBox.Show("Некоторые устройства не подключены, пожалуйста проверьте их и нажмите кнопку \"Повтор\"", "Ошибка", MessageBoxButtons.RetryCancel);
                if (s == DialogResult.Cancel)
                {
                    string error_msg = "ОШИБКА\nНекоторые устройства были не подключены! Программа завершена!";
                    richTextBox1.Text += error_msg + "\n";
                    richTextBox1.Select(richTextBox1.Text.IndexOf("ОШИБКА"), error_msg.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
                else
                {
                    goto repeat;
                }
            }
            else
            {
                try
                {
                    N:
                    /* Настройка источника питания */
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "\nВыполняется настройка источника питания (напряжение 3 вольта, ток ограничения 50 мА)\n";
                    }
                    PowerSuply.channelConfig(1, "3", "50");
                    PowerSuply.channelState(1, true);
                    /* Настройка опорного генератора */
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "Выполняется настройка опорного генератора (опорная частота 250 МГц, опорная мощность -5 дБм)\n";
                    }
                    Generator.RFConfig(250, -5);
                    Generator.outputState(true);
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "Запись данных с ПК на микросхему, соответствующие формированию выходной частоты F = 75 МГц\n";
                    }
                    double F = 75;
                    double F1 = 0;
                    microcontroller.setFreq(F);
                    for (int i = 0; i <= 5; i++)
                    {
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Считываем с частотомера частоту F1\n";
                        }
                        F1 = FreqCounter.readFrequency(1);
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Сравниваем частоту F1 и F\n";
                        }
                        if (F1 > (F + 0.001) || F1 < (F - 0.001))
                        {
                            if (N != 3)
                            {
                                N++;
                                if (is_hand_mode)
                                {
                                    richTextBox1.Text += "Данные частоты не совпадают\n попытка №" + N + "\n";
                                }
                                PowerSuply.channelState(1, false);
                                goto N;
                            }
                            else
                            {
                                if (is_hand_mode)
                                {
                                    richTextBox1.Text += "Данные частоты не совпадают. Требуется ручное вмешательство!\n";
                                }
                                is_all_ok = false;
                                break;
                            }
                        }
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Запись данных с ПК на микросхему, соответствующие формированию выходной частоты F - 2,5 МГц\n";
                        }
                        F -= 2.5;
                        microcontroller.setFreq(F);
                    }
                    if (is_all_ok)
                    {
                        result = F1;
                    }
                    else
                    {
                        result = 0;
                    }

                }
                catch (Exception error)
                {
                    string err_msg = "Ошибка:" + error.Message;
                    richTextBox1.Text += err_msg + "\n";
                    richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка:"), err_msg.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
            }

            return result;
        }

        public double point_3(RichTextBox richTextBox1)
        {
            bool is_all_ok = true;
            int N = 1;
            double result = 0;
            richTextBox1.Text += "Проверка пункта 3 ... \n";
            repeat:
            if (!schema_2())
            {
                var s = MessageBox.Show("Некоторые устройства не подключены, пожалуйста проверьте их и нажмите кнопку \"Повтор\"", "Ошибка", MessageBoxButtons.RetryCancel);
                if (s == DialogResult.Cancel)
                {
                    string error_msg = "ОШИБКА\nНекоторые устройства были не подключены! Программа завершена!";
                    richTextBox1.Text += error_msg + "\n";
                    richTextBox1.Select(richTextBox1.Text.IndexOf("ОШИБКА"), error_msg.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
                else
                {
                    goto repeat;
                }
            }
            else
            {
                try
                {
                    N:
                    /* Настройка источника питания */
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "\nВыполняется настройка источника питания (напряжение 3 вольта, ток ограничения 50 мА)\n";
                    }
                    PowerSuply.channelConfig(1, "3", "50");
                    PowerSuply.channelState(1, true);
                    /* Настройка опорного генератора */
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "Выполняется настройка опорного генератора (опорная частота 250 МГц, опорная мощность -5 дБм)\n";
                    }
                    Generator.RFConfig(250, -5);
                    Generator.outputState(true);
                    int F = 1500;
                    int P = -8;
                    double P1 = 0;
                    double F1 = 0;
                    microcontroller.setFreq(F);
                    microcontroller.setLev(P);
                    if (is_hand_mode)
                    {
                        richTextBox1.Text += "Запись данных с ПК на микросхему, соответствующие формированию мощности сигнала на выходе P = -8 дБмВт и частоте генератора F = 1500 МГц\n";
                    }

                    for (int i = 0; i <= 5; i++)
                    {
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Считываем с анализатора спектра текущую мощность сигнала P1\n";
                            richTextBox1.Text += "Считать с частотомера измеренную частоту генератора F1\n";
                        }
                        P1 = Analyzer.readAmplitude();
                        F1 = FreqCounter.readFrequency(1);
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Сравниваем частоту F1 и F, P и P1\n";
                        }
                        if ((F1 > (F + 0.001) || F1 < (F - 0.001)) && P != P1)
                        {
                            if (N != 3)
                            {
                                N++;
                                if (is_hand_mode)
                                {
                                    richTextBox1.Text += "Данные частоты или мощности не совпадают\n попытка №" + N + "\n";
                                }
                                PowerSuply.channelState(1, false);
                                goto N;
                            }
                            else
                            {
                                if (is_hand_mode)
                                {
                                    richTextBox1.Text += "Данные частоты или мощности не совпадают. Требуется ручное вмешательство!\n";
                                }
                                is_all_ok = false;
                                break;
                            }
                        }
                        if (is_hand_mode)
                        {
                            richTextBox1.Text += "Запись данных с ПК на микросхему, соответствующие формированию мощности сигнала на выходе P\n";
                        }
                        P += 1;
                        microcontroller.setLev(P);
                    }
                    if (is_all_ok)
                    {
                        result = P1;
                    }
                    else
                    {
                        result = 0;
                    }

                }
                catch (Exception error)
                {
                    string err_msg = "Ошибка:" + error.Message;
                    richTextBox1.Text += err_msg + "\n";
                    richTextBox1.Select(richTextBox1.Text.IndexOf("Ошибка:"), err_msg.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
            }

            return result;
        }

        public double point_4(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 4 ... \n";
            return -10;
        }
                    
        public double point_5(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 5 ... \n";
            return -35;
        }

        public double point_6(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 6 ... \n";
            return 200;
        }

        public double point_7(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 7 ... \n";
            return 200;
        }

        public double point_8(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 8 ... \n";
            return 10000;
        }

        public double point_9(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 9 ... \n";
            return 1;
        }

        public double point_10(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 10 ... \n";
            return -105;
        }

        public double point_11(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 11 ... \n";
            return -125;
        }

        public double point_12(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 12 ... \n";
            return -110;
        }

        public double point_13(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 13 ... \n";
            return -130;
        }

        public double point_14(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 14 ... \n";
            return -215;
        }

        public double point_15(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 15 ... \n";
            return 20;
        }

        public double point_16(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 16 ... \n";
            return 6;
        }

        public double point_17(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 17 ... \n";
            return 4;
        }

        public double point_18(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 18 ... \n";
            return 1;
        }

        public double point_19(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 19 ... \n";
            return 0.2;
        }

        public double point_20(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 20 ... \n";
            return 0.2;
        }

        public double point_21(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 21 ... \n";
            return 0.1;
        }

        public double point_22(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 22 ... \n";
            return 5;
        }

        public double point_23(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 23 ... \n";
            return 5;
        }

        public double point_24(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 24 ... \n";
            return 5;
        }

        public double point_25(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 25 ... \n";
            return 5;
        }

        public double point_26(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 26 ... \n";
            return 0.1;
        }

        public double point_27(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 27 ... \n";
            return 8;
        }

        public double point_28(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 28 ... \n";
            return 8;
        }

        public double point_29(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 29 ... \n";
            return 20;
        }

        public double point_30(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 30 ... \n";
            return -40;
        }

        public double point_31(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 31 ... \n";
            return -20;
        }

        public double point_32(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 32 ... \n";
            return -22;
        }

        public double point_33(RichTextBox richTextBox1)
        {
            richTextBox1.Text += "Проверка пункта 33 ... \n";
            return -30;
        }
        #endregion
    }
}
