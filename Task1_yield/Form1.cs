using System;
using System.Collections.Generic;
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
            //пытаемся конвертнуть текст из текстбоксов в переменные DateTime и сделать с ними положенные действия =)
            try
            {
                _startDate = Convert.ToDateTime(textBoxA.Text);
                _endDate = Convert.ToDateTime(textBoxB.Text);

                //Fixed: Move this part of code from button - because only if we have succeeded converting to Dates, we can do something with them
                var resultText = string.Empty;
                //FIXED: -if (Range(_startDate, _endDate).FirstOrDefault() != default(DateTime)); -else
                foreach (var dta in Range(_startDate, _endDate))
                    //FIXED -> -CultureInfo.InvariantCulture
                    resultText += dta.ToString("D") + Environment.NewLine;
                if (string.IsNullOrEmpty(resultText))
                    resultText = "There are no dates between";
                richTextBox_Result.Text = resultText;
            }
            catch (FormatException e)
            {
                var errorMessage = e.Message;
                //FIXED: +MessageBoxIcon.Error
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            richTextBox_Result.Text = string.Empty;
            to_Date_Time();
        }

        //внутри требуемый yield
        //FIXED: +startDate, endDate
        //FIXED: inverting conditions - if => argEx, for => yield return
        public static IEnumerable<DateTime> Range(DateTime startDate, DateTime endDate)
        {
            if (endDate <= startDate.AddDays(1))
            {
                //FIXED: +argEx
                var argEx = new ArgumentException("Start date must be less, than end");
                MessageBox.Show(argEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw argEx;
            }
            for (var d = startDate.AddDays(1); d < endDate; d = d.AddDays(1))
                yield return d;
        }
    }
}