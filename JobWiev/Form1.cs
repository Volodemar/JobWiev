using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace JobWiev
{
    public partial class Form1 : Form
    {
        private int CurrentTask = 0;
        private double TaskTime1 = 0;
        private double TaskTime2 = 0;
        private double TaskTime3 = 0;
        private double Modify = 5*60;

        public Form1()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                //Расчет ставки в минуту
                MoneySecond.Text = Convert.ToString(Convert.ToDouble(MoneyHour.Text) / 60 / 60);
                ModifyColor();
                Hashtable test = new Hashtable();
                test.Add("1", "Абра кадабра");
                test.Add("2", "Абра кадабра2");
                test.Add("3", "Абра кадабра3");
                test.Add("4", "Абра кадабра еу!");
                dataGridView1.DataSource = test.Cast<DictionaryEntry>().Select(x => new {Col1 = x.Key.ToString(), Col2 = x.Value.ToString()}).ToList();
            }
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            //Переключился на задачу №1
            TimerJob.Start();
            CurrentTask = 1;
            ModifyColor();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            //Переключился на задачу №2
            TimerJob.Start();
            CurrentTask = 2;
            ModifyColor();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            //Переключился на задачу №3
            TimerJob.Start();
            CurrentTask = 3;
            ModifyColor();
        }

        private void buttonTaskStop_Click(object sender, EventArgs e)
        {
            //Выключил задачи
            TimerJob.Stop();
            CurrentTask = 0;
            ModifyColor();
        }

        private void TimerJob_Tick(object sender, EventArgs e)
        {
            if (CurrentTask == 1)
            {
                TaskTime1 = TaskTime1 + 1;
            }

            if (CurrentTask == 2)
            {
                TaskTime2 = TaskTime2 + 1;
            }

            if (CurrentTask == 3)
            {
                TaskTime3 = TaskTime3 + 1;
            }

            ModifyTable();
        }

        private void ModifyTable()
        {
            TaskMinute1.Text = Convert.ToString(Math.Round(TaskTime1 / 60, 2));
            TaskHour1.Text = Convert.ToString(Math.Round(TaskTime1 / 60 / 60, 2));
            TaskSumma1.Text = Convert.ToString(Math.Round(TaskTime1 * Convert.ToDouble(MoneySecond.Text), 2));

            TaskMinute2.Text = Convert.ToString(Math.Round(TaskTime2 / 60, 2));
            TaskHour2.Text = Convert.ToString(Math.Round(TaskTime2 / 60 / 60, 2));
            TaskSumma2.Text = Convert.ToString(Math.Round(TaskTime2 * Convert.ToDouble(MoneySecond.Text), 2));

            TaskMinute3.Text = Convert.ToString(Math.Round(TaskTime3 / 60, 2));
            TaskHour3.Text = Convert.ToString(Math.Round(TaskTime3 / 60 / 60, 2));
            TaskSumma3.Text = Convert.ToString(Math.Round(TaskTime3 * Convert.ToDouble(MoneySecond.Text), 2));

            double TaskTimeITOG = TaskTime1 + TaskTime2 + TaskTime3;
            TaskMinuteITOG.Text = Convert.ToString(Math.Round(TaskTimeITOG / 60, 2));
            TaskHourITOG.Text = Convert.ToString(Math.Round(TaskTimeITOG / 60 / 60, 2));
            TaskSummaITOG.Text = Convert.ToString(Math.Round(TaskTimeITOG * Convert.ToDouble(MoneySecond.Text), 2));
        }

        private void buttonSBROS_Click(object sender, EventArgs e)
        {
            if (TaskTime1 + TaskTime2 + TaskTime3 == 0)
            {
                Task1.Text = "";
                Task2.Text = "";
                Task3.Text = "";
            }
            else
            {
                //Выключил задачи
                TimerJob.Stop();
                CurrentTask = 0;
                TaskTime1 = 0;
                TaskTime2 = 0;
                TaskTime3 = 0;
                Modify = 5 * 60;
            }
            ModifyColor();
        }

        private void ModifyColor()
        {
            buttonAdd_30.BackColor = SystemColors.Control;
            buttonAdd_10.BackColor = SystemColors.Control;
            buttonAdd_5.BackColor = SystemColors.Control;
            buttonMinus_5.BackColor = SystemColors.Control;
            buttonMinus_10.BackColor = SystemColors.Control;
            buttonMinus_30.BackColor = SystemColors.Control;
            if (Modify == 5 * 60)
            {
                buttonAdd_5.BackColor = Color.Yellow;
                buttonModify1.Text = "+";
                buttonModify2.Text = "+";
                buttonModify3.Text = "+";
            }
            if (Modify == 10 * 60)
            {
                buttonAdd_10.BackColor = Color.Yellow;
                buttonModify1.Text = "+";
                buttonModify2.Text = "+";
                buttonModify3.Text = "+";
            }
            if (Modify == 30 * 60)
            {
                buttonAdd_30.BackColor = Color.Yellow;
                buttonModify1.Text = "+";
                buttonModify2.Text = "+";
                buttonModify3.Text = "+";
            }
            if (Modify == -5 * 60)
            {
                buttonMinus_5.BackColor = Color.Yellow;
                buttonModify1.Text = "-";
                buttonModify2.Text = "-";
                buttonModify3.Text = "-";
            }
            if (Modify == -10 * 60)
            {
                buttonMinus_10.BackColor = Color.Yellow;
                buttonModify1.Text = "-";
                buttonModify2.Text = "-";
                buttonModify3.Text = "-";
            }
            if (Modify == -30 * 60)
            {
                buttonMinus_30.BackColor = Color.Yellow;
                buttonModify1.Text = "-";
                buttonModify2.Text = "-";
                buttonModify3.Text = "-";
            }

            if(CurrentTask == 0)
            {
                buttonTask1.BackColor = SystemColors.Control;
                buttonTask2.BackColor = SystemColors.Control;
                buttonTask3.BackColor = SystemColors.Control;
                buttonTaskStop.BackColor = Color.Green;
            }
            if (CurrentTask == 1)
            {
                buttonTask1.BackColor = Color.Green;
                buttonTask2.BackColor = SystemColors.Control;
                buttonTask3.BackColor = SystemColors.Control;
                buttonTaskStop.BackColor = SystemColors.Control;
            }
            if (CurrentTask == 2)
            {
                buttonTask1.BackColor = SystemColors.Control;
                buttonTask2.BackColor = Color.Green;
                buttonTask3.BackColor = SystemColors.Control;
                buttonTaskStop.BackColor = SystemColors.Control;
            }
            if (CurrentTask == 3)
            {
                buttonTask1.BackColor = SystemColors.Control;
                buttonTask2.BackColor = SystemColors.Control;
                buttonTask3.BackColor = Color.Green;
                buttonTaskStop.BackColor = SystemColors.Control;
            }
        }

        private void buttonAdd_30_Click(object sender, EventArgs e)
        {
            Modify = 30 * 60;
            ModifyColor();
        }

        private void buttonMinus_30_Click(object sender, EventArgs e)
        {
            Modify = -30 * 60;
            ModifyColor();
        }

        private void buttonAdd_10_Click(object sender, EventArgs e)
        {
            Modify = 10 * 60;
            ModifyColor();
        }

        private void buttonMinus_10_Click(object sender, EventArgs e)
        {
            Modify = -10 * 60;
            ModifyColor();
        }

        private void buttonAdd_5_Click(object sender, EventArgs e)
        {
            Modify = 5 * 60;
            ModifyColor();
        }

        private void buttonMinus_5_Click(object sender, EventArgs e)
        {
            Modify = -5 * 60;
            ModifyColor();
        }

        private void buttonLast1_Click(object sender, EventArgs e)
        {
            if(Math.Abs(Modify) > TaskTime1)
            {
                TaskTime3 = TaskTime3 + TaskTime1;
                TaskTime1 = 0;
            }
            else
            {
                TaskTime3 = TaskTime3 + Math.Abs(Modify);
                TaskTime1 = TaskTime1 - Math.Abs(Modify);
            }
        }

        private void buttonLast2_Click(object sender, EventArgs e)
        {
            if (Math.Abs(Modify) > TaskTime2)
            {
                TaskTime1 = TaskTime1 + TaskTime2;
                TaskTime2 = 0;
            }
            else
            {
                TaskTime1 = TaskTime1 + Math.Abs(Modify);
                TaskTime2 = TaskTime2 - Math.Abs(Modify);
            }
        }

        private void buttonLast3_Click(object sender, EventArgs e)
        {
            if (Math.Abs(Modify) > TaskTime3)
            {
                TaskTime2 = TaskTime2 + TaskTime3;
                TaskTime3 = 0;
            }
            else
            {
                TaskTime2 = TaskTime2 + Math.Abs(Modify);
                TaskTime3 = TaskTime3 - Math.Abs(Modify);
            }
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            if (Math.Abs(Modify) > TaskTime1)
            {
                TaskTime2 = TaskTime2 + TaskTime1;
                TaskTime1 = 0;
            }
            else
            {
                TaskTime2 = TaskTime2 + Math.Abs(Modify);
                TaskTime1 = TaskTime1 - Math.Abs(Modify);
            }
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            if (Math.Abs(Modify) > TaskTime2)
            {
                TaskTime3 = TaskTime3 + TaskTime2;
                TaskTime2 = 0;
            }
            else
            {
                TaskTime3 = TaskTime3 + Math.Abs(Modify);
                TaskTime2 = TaskTime2 - Math.Abs(Modify);
            }
        }

        private void buttonNext3_Click(object sender, EventArgs e)
        {
            if (Math.Abs(Modify) > TaskTime3)
            {
                TaskTime1 = TaskTime1 + TaskTime3;
                TaskTime3 = 0;
            }
            else
            {
                TaskTime1 = TaskTime1 + Math.Abs(Modify);
                TaskTime3 = TaskTime3 - Math.Abs(Modify);
            }
        }

        private void buttonModify1_Click(object sender, EventArgs e)
        {
            if (TaskTime1 + Modify > 0)
                TaskTime1 = TaskTime1 + Modify;
            else
            {
                TaskTime1 = 0;
                Task1.Text = "";
            }
        }

        private void buttonModify2_Click(object sender, EventArgs e)
        {
            if (TaskTime2 + Modify > 0)
                TaskTime2 = TaskTime2 + Modify;
            else
            {
                TaskTime2 = 0;
                Task2.Text = "";
            }
        }

        private void buttonModify3_Click(object sender, EventArgs e)
        {
            if (TaskTime3 + Modify > 0)
                TaskTime3 = TaskTime3 + Modify;
            else
            {
                TaskTime3 = 0;
                Task3.Text = "";
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            ModifyTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\Program Files\\Notepad++\\notepad++.exe", "d:\\Work\\PR\\MyWiki\\!Основные метаданные.cs");
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\Program Files\\Notepad++\\notepad++.exe", "d:\\Work\\PR\\MyWiki\\!Основные обработчики.cs");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\Program Files\\Notepad++\\notepad++.exe", "d:\\Work\\PR\\MyWiki\\!ОРАКЛ ТОП СКРИПТЫ.sql");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\Program Files\\Notepad++\\notepad++.exe", "d:\\Work\\PR\\MyWiki\\!SQL шаблоны.sql");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\Program Files\\Notepad++\\notepad++.exe", "d:\\Work\\PR\\MyWiki\\!Фишки Oracle.sql");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\Program Files\\Notepad++\\notepad++.exe", "d:\\Work\\PR\\MyWiki\\!Фишки C#.cs");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\Program Files\\Notepad++\\notepad++.exe", "d:\\Work\\PR\\MyWiki\\!Фишки.vb");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("d:\\Work\\PR\\RIP2\\ClientLoader.lnk");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("d:\\Work\\PR\\RIP2\\SOURCES\\CLIENT\\Client.sln");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("d:\\Work\\PR\\RIP2\\Build.bat");    
        }
    }
}
