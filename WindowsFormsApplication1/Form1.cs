using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            Text = "Программа автоматизации расчетного ТЭО";
            label1.Text = "Программа автоматизации расчетного ТЭО";
            label2.Text = "Расчет КТС";
            label3.Text = "Расчет плана-графика работ";
            label4.Text = "Расчет затрат на разработку проекта и внедрение аналога";
            label5.Text = "Расчет эксплутационных затрат";
            label6.Text = "Расчет показателей экономической эффективности";
            label7.Text = "Информация о разработчиках";
            button1.Text = "Модуль 1";
            button2.Text = "Модуль 2";
            button3.Text = "Модуль 3";
            button4.Text = "Модуль 4";
            button5.Text = "Модуль 5";
            button6.Text = "Модуль 6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form = new Form2();
            form.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 form = new Form7();
            form.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form = new Form4();
            form.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form = new Form5();
            form.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 form = new Form6();
            form.ShowDialog();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            Close();
        }
    }
}
