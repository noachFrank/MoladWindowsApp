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

            StartCorrectly();

            Display();

        }

        private DateTime _molad = new DateTime(2016, 10, 01, 14, 40, 13, 000);

        private int _chalakim = 4;

        private static List<string> _cycle19Year = JewishMonths();

        private int _jewishYear = 5777;

        private int _index = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Increments The Molad By One And Displays It

            btnPrev.Enabled = true;

            GoForward();

            btnNext.Enabled = _molad <= DateTime.MaxValue.AddDays(-4);

            Display();
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {

            // Decrements The Molad By One And Displays It

            btnNext.Enabled = true;

            GoBackward();

            btnPrev.Enabled = _molad >= DateTime.MinValue.AddMonths(1);

            Display();

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Opens Form To Enter Search With Jewish Dates And Displays It

            Searcher s = new Searcher();

            s.ShowDialog();

            if (!s.IsAMonth())
            {
                return;
            }

            else if (!s.IsGoodYear())
            {
                return;
            }

            JewishSearch(s.GetMonthSearch().ToUpper(), int.Parse(s.GetYearSearch()));

            Display();

            btnNext.Enabled = true;
            btnPrev.Enabled = true;

        }

        private void btnSearchEnglish_Click(object sender, EventArgs e)
        {
            // Opens Form To Enter Search With English Dates And Displays It

            EnglishSearch es = new EnglishSearch();

            es.ShowDialog();

            EnglishSearch(es.SearchedDate());

            Display();

            btnNext.Enabled = true;
            btnPrev.Enabled = true;

        }

        private void JewishSearch(string month, int year)
        {
            // Searches For Input Molad

            if (year >= _jewishYear)
            {
                while (true)
                {
                    if (month.Contains(_cycle19Year[_index]) && year == _jewishYear)
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
                    if (month.Contains(_cycle19Year[_index]) && year == _jewishYear)

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

        private void EnglishSearch(DateTime dt)
        {
            // Searches For Closest Molad To Input Date
           

            if (dt >= _molad)
            {
                while (true)
                {
                    if (_molad <= dt.AddDays(14).AddHours(19) && _molad >= dt.AddDays(-14).AddHours(-19))
                    {
                        break;
                    }

                    else
                    {
                        GoForward();
                    }
                }
            }

            else if (dt <= _molad)
            {
                while (true)
                {
                    if (_molad <= dt.AddDays(14).AddHours(12) && _molad >= dt.AddDays(-14).AddHours(-12))
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

            _chalakim++;


            if (_chalakim == 18)
            {
                _molad = _molad.AddDays(29).AddHours(12).AddMinutes(45);

                _chalakim = 0;
            }
            else
            {
                _molad = _molad.AddDays(29).AddHours(12).AddMinutes(44);

            }

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

            _chalakim--;

            if (_chalakim < 0)
            {
                _molad = _molad.AddDays(-29).AddHours(-12).AddMinutes(-45);

                _chalakim = 17;
            }
            else
            {
                _molad = _molad.AddDays(-29).AddHours(-12).AddMinutes(-44);

            }



        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            StartCorrectly();

            Display();
        }

        private void StartCorrectly()
        {
            //Starts Display At Current Month

            while (true)
            {
                if (_molad <= DateTime.Now)
                {
                    if (_molad >= DateTime.Now && _molad <= DateTime.Now.AddMonths(1))
                    {
                        break;
                    }

                    else
                    {
                        GoForward();
                    }
                }

                else
                {
                    if (_molad >= DateTime.Now && _molad <= DateTime.Now.AddMonths(1))
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

        private void Display()
        {
            // displays molad

            txtMolad.Text = $"{_molad.DayOfWeek.ToString()}  {_molad.Month}/{_molad.Day}/{_molad.Year}  {_molad.ToString("h:mm tt")}";
            
            if (_chalakim == 1)
            {
                txtMolad.Text += $"  And {_chalakim} Chelek";
            }
            else if (_chalakim != 0)
            {
                txtMolad.Text += $"  And {_chalakim} Chalakim";
            }

            txtMonth.Text = $"Molad Of {_cycle19Year[_index]} {_jewishYear}";



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



