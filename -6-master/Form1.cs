using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_1;

namespace _6_master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Triad firstTriad = new Triad(int.Parse(firstNumFirstTriad.Text), int.Parse(secondNumFirstTriad.Text), int.Parse(thirdNumFirstTriad.Text));
                Triad secondTriad = new Triad(int.Parse(firstNumSecondTriad.Text), int.Parse(secondNumSecondTriad.Text), int.Parse(thirdNumSecondTriad.Text));

                //Проверка на равенство и вывод результата
                if (firstTriad == secondTriad)
                    rezult1.Text = "Триады не равны";
                else
                    rezult1.Text = "Триады равны";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректныe значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Triad firstTriad = new Triad(int.Parse(firstNumFirstTriad.Text), int.Parse(secondNumFirstTriad.Text), int.Parse(thirdNumFirstTriad.Text));

                //Проверка первой триады на четность и вывод результата
                if (firstTriad % 2)
                    rezult2.Text = "Вся тройка чисел четна";
                else
                    rezult2.Text = "Не вся тройка чисел четна";
            }
            catch(FormatException)
            {
                MessageBox.Show("Введите корректныe значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Triad secondTriad = new Triad(int.Parse(firstNumSecondTriad.Text), int.Parse(secondNumSecondTriad.Text), int.Parse(thirdNumSecondTriad.Text));

                //Проверка второй триады на четность и вывод результата
                if (secondTriad % 2)
                    rezult3.Text = "Вся тройка чисел четна";
                else
                    rezult3.Text = "Не вся тройка чисел четна";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректныe значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №6\n" +
                "Использовать класс Triad(тройка нечетных чисел).\n" +
                "Разработать операции проверки полного равенства / неравенства чисел в триадах(a1, b1, c1) == (a2, b2, c2).\n" +
                "Разработать операции определения, что вся тройка чисел нечетна true / false.\n" +
                "Разработчик: Гусев Ярослав ИСП-31");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNumFirstTriad.Clear();
            secondNumFirstTriad.Clear();
            thirdNumFirstTriad.Clear();
            firstNumSecondTriad.Clear();
            secondNumSecondTriad.Clear();
            thirdNumSecondTriad.Clear();
            rezult2.Clear();
            rezult3.Clear();
            rezult1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №6\n" +
    "Использовать класс Triad (тройка нечетных чисел).\n" +
    "Разработать операции проверки полного равенства / неравенства чисел в триадах(a1, b1, c1) == (a2, b2, c2).\n" +
    "Разработать операции определения, что вся тройка чисел нечетна true / false.\n" +
    "Разработчик: Гусев Ярослав ИСП-31");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
