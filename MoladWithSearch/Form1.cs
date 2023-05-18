using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoladWithSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtMolad.Text = _molad.ToString();

            txtMonth.Text = $"Molad Of {_cycle19Year[_index]} {_jewishYear}";


        }

        private DateTime _molad = new DateTime(2016, 10, 01, 14, 40, 13, 000);

        private static List<string> _cycle19Year = JewishMonths();

        private int _jewishYear = 5777;

        private int _index = 0;



        private void btnNext_Click(object sender, EventArgs e)
        {
            // Increments The Molad By One And Displays It

            GoForward();

            btnNext.Enabled = _molad <= DateTime.MaxValue.AddMinutes(-1);


            txtMolad.Text = _molad.ToString();

            txtMonth.Text = $"Molad Of {_cycle19Year[_index]} {_jewishYear}";
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {

            // Decrements The Molad By One And Displays It

            GoBackward();

            btnPrev.Enabled = _molad >= DateTime.MinValue.AddMonths(1);

            txtMolad.Text = _molad.ToString();

            txtMonth.Text = $"Molad Of {_cycle19Year[_index]} {_jewishYear}";

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Opens Form To Enter Search And Displays It

            Searcher s = new Searcher();

            s.ShowDialog();

            if (s.GetMonthSearch() == "" || s.GetYearSearch() == "")
            {
                return;
            }


            MoladSearch(s.GetMonthSearch(), int.Parse(s.GetYearSearch()));

            txtMolad.Text = _molad.ToString();

            txtMonth.Text = $"Molad Of {_cycle19Year[_index]} {_jewishYear}";


        }

        private void MoladSearch(string month, int year)
        {
            // Searches For Input Molad

            if (year >= _jewishYear)
            {
                while (true)
                {
                    if (month == _cycle19Year[_index] && year == _jewishYear)
                    {
                        break;
                    }

                    else
                    {
                        GoForward();

                    }
                }
            }


            else if (year <= _jewishYear)
            {
                while (true)
                {
                    if (month == _cycle19Year[_index] && year == _jewishYear)
                    {
                        break;
                    }

                    else
                    {
                        GoBackward();
                    }
                }
            }
        }

        private void GoForward()
        {
            // Increments The Molad By One

            if (_cycle19Year[_index] == "ELUL")
            {
                _jewishYear++;
            }

            if (_index == _cycle19Year.Count - 1)
            {
                _index = 0;
            }
            else
            {

                _index++;
            }

            _molad = _molad.AddDays(29).AddHours(12).AddMinutes(44).AddSeconds(3).AddMilliseconds(333);



        }

        private void GoBackward()
        {
            // Decrements The Molad By One

            if (_cycle19Year[_index] == "TISHREI")
            {
                _jewishYear--;
            }

            if (_index == 0)
            {
                _index = _cycle19Year.Count - 1;
            }
            else
            {

                _index--;
            }

            _molad = _molad.AddDays(-29).AddHours(-12).AddMinutes(-44).AddSeconds(-3).AddMilliseconds(-333);


        }

        private static List<string> JewishMonths()
        {
            // Creates A List Of Jewish Months For A 19 Year Cycle

            List<string> regularYear = new List<string>();

            regularYear.Add("TISHREI");
            regularYear.Add("CHESHVAN");
            regularYear.Add("KISLEV");
            regularYear.Add("TEVES");
            regularYear.Add("SHEVAT");
            regularYear.Add("ADAR");
            regularYear.Add("NISSAN");
            regularYear.Add("IYAR");
            regularYear.Add("SIVAN");
            regularYear.Add("TAMUZ");
            regularYear.Add("AV");
            regularYear.Add("ELUL");

            List<string> leapYear = new List<string>();

            leapYear.Add("TISHREI");
            leapYear.Add("CHESHVAN");
            leapYear.Add("KISLEV");
            leapYear.Add("TEVES");
            leapYear.Add("SHEVAT");
            leapYear.Add("ADAR 1");
            leapYear.Add("ADAR 2");
            leapYear.Add("NISSAN");
            leapYear.Add("IYAR");
            leapYear.Add("SIVAN");
            leapYear.Add("TAMUZ");
            leapYear.Add("AV");
            leapYear.Add("ELUL");



            List<string> allYears = new List<string>();

            //1
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //2
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //3
            for (int i = 0; i < leapYear.Count; i++)
            {
                allYears.Add(leapYear[i]);
            }

            //4
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //5
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //6
            for (int i = 0; i < leapYear.Count; i++)
            {
                allYears.Add(leapYear[i]);
            }

            //7
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //8
            for (int i = 0; i < leapYear.Count; i++)
            {
                allYears.Add(leapYear[i]);
            }

            //9
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //10
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //11
            for (int i = 0; i < leapYear.Count; i++)
            {
                allYears.Add(leapYear[i]);
            }

            //12
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //13
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //14
            for (int i = 0; i < leapYear.Count; i++)
            {
                allYears.Add(leapYear[i]);
            }

            //15
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //16
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //17
            for (int i = 0; i < leapYear.Count; i++)
            {
                allYears.Add(leapYear[i]);
            }

            //18
            for (int i = 0; i < regularYear.Count; i++)
            {
                allYears.Add(regularYear[i]);
            }

            //19
            for (int i = 0; i < leapYear.Count; i++)
            {
                allYears.Add(leapYear[i]);
            }

            return allYears;


        }
    }
}

    

