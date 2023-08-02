using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoladWithSearch
{
    public partial class EnglishSearch : Form
    {
        public EnglishSearch()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!IsGoodDayAndMonth())
            {
                MessageBox.Show("Please enter the date in the correct format");
            }

            else if (!IsGoodYear())
            {
                MessageBox.Show("Please enter a year between 1 and 10000");
            }
            else
            {
                Close();
            }

        }

        public DateTime SearchedDate()
        {
            string timeString = $"{txtDay.Text}{txtMonth.Text}{txtYear.Text}";
            return DateTime.ParseExact(timeString,"ddMMyyyy", CultureInfo.InvariantCulture);
        }

        public bool IsGoodDayAndMonth()
        {
            int day;
            int month;

            if (!int.TryParse(txtMonth.Text, out month) || !int.TryParse(txtMonth.Text, out day)
                || int.Parse(txtDay.Text) >= 31 ||int.Parse(txtMonth.Text) >= 13) 
            {
                return false;
            }

            return true;
        }

        public bool IsGoodYear()
        {
            int year;
            if(!int.TryParse(txtYear.Text,out year) || int.Parse(txtYear.Text) > 100000 || int.Parse(txtYear.Text) < 1)
            {
                return false;
            }
            return true;
        }
    }
}
