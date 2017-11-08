using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Task1_yield
{
    public partial class Form1 : Form
    {
        private DateTime _a, _b;

        public Form1()
        {
            InitializeComponent();
        }

        public void to_Date_Time()
        {
            //пытаемся конвертнуть текст из текстбоксов в переменные DateTime
            try
            {
                _a = Convert.ToDateTime(textBoxA.Text);
                _b = Convert.ToDateTime(textBoxB.Text);
            }
            //другого эксепшена не смог добиться, было предположение перегрузить(ArgumentOutOfRangeException),
            //но не получилось придумать кейс - год с 0001 работает, 9999 тоже
            //FIXED - более корректная и полная по инфе обработка исключения
            catch (FormatException e)
            {
                var errorMessage = e.Message + Environment.NewLine + Environment.NewLine
                                   + e.StackTrace + Environment.NewLine + Environment.NewLine
                                   + e.Source + Environment.NewLine
                                   + e.Data;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK);
            }
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            richTextBox_Result.Text = "";

            to_Date_Time();
            //if (Range(a, b).Count() >=1) //слишком тяжёлая операция на большой дистанции, а .First() крэшит при отсутствии элемента, пока не вижу иного способа
            //FIXED
            if (Range(_a, _b).FirstOrDefault() != default(DateTime)
            ) //Прозрел на решение, проблема проверки на непустоту первого значения решена
                foreach (var dta in Range(_a, _b))
                    richTextBox_Result.Text += dta.ToString("D", new CultureInfo("en-US")) + Environment.NewLine;
            else
                richTextBox_Result.Text = "There are no dates between";
        }

        //требуемый метод, можно и сокращённо т.к. в using есть 
        //IEnumerable<DateTime> Range(DateTime first, DateTime second)
        //внутри требуемые yield
        public static IEnumerable<DateTime> Range(DateTime first, DateTime second)
        {
            TimeSpan Difference;
            DateTime result;

            if (second > first.AddDays(1))
            {
                Difference = second - first;
                for (var i = 1; i < Difference.Days; i++)
                {
                    result = first.AddDays(i);
                    yield return result;
                }
            }
            else
            {
                MessageBox.Show("First date must be less, than second", "Error", MessageBoxButtons.OK);
            }
        }
    }
}