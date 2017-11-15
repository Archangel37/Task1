using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Task1_yield
{
    public partial class Form1 : Form
    {
        //FIXED -> -a,b / +_startDate, _endDate
        private DateTime _startDate, _endDate;

        public Form1()
        {
            InitializeComponent();
        }

        public void to_Date_Time()
        {
            //пытаемся конвертнуть текст из текстбоксов в переменные DateTime
            try
            {
                _startDate = Convert.ToDateTime(textBoxA.Text);
                _endDate = Convert.ToDateTime(textBoxB.Text);
            }
            //FIXED - более корректная и полная по инфе обработка исключения
            catch (FormatException e)
            {
                var errorMessage = e.Message;
                // оставил для себя комментом для дальнейшего изучения, что ещё можно снимать с эксепшенов
                // + Environment.NewLine + Environment.NewLine
                //                   + e.StackTrace + Environment.NewLine + Environment.NewLine
                //                   + e.Source + Environment.NewLine
                //                   + e.Data;
                //FIXED: +MessageBoxIcon.Error
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            //Fixed my poor code style -> -"" / +String.Empty
            richTextBox_Result.Text = string.Empty;
            //FIXED: +resultText
            var resultText = string.Empty;
            to_Date_Time();
            //FIXED before
            if (Range(_startDate, _endDate).FirstOrDefault() != default(DateTime))
                foreach (var dta in Range(_startDate, _endDate))
                    //FIXED -> -new System.Globalization.CultureInfo("en-US") ) / +CultureInfo.InvariantCulture
                    resultText += dta.ToString("D", CultureInfo.InvariantCulture) + Environment.NewLine;
            else
                resultText = "There are no dates between";

            richTextBox_Result.Text = resultText;
        }

        //внутри требуемый yield
        //FIXED: +startDate, endDate
        public static IEnumerable<DateTime> Range(DateTime startDate, DateTime endDate)
        {
            if (endDate > startDate.AddDays(1))
            {
                //FIXED: cycle 'for'
                for (var d = startDate.AddDays(1); d < endDate; d = d.AddDays(1))
                    yield return d;
            }
            else
            {
                //FIXED: +argEx
                var argEx = new ArgumentException("Start date must be less, than end");
                MessageBox.Show(argEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw argEx;
            }
        }
    }
}