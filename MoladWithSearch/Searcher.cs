using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoladWithSearch
{
    public partial class Searcher : Form
    {
        public Searcher()
        {
            InitializeComponent();

            //cmbMonth.FormattingEnabled = false;

            cmbMonth.Items.Add("TISHREI");
            cmbMonth.Items.Add("CHESHVAN");
            cmbMonth.Items.Add("KISLEV");
            cmbMonth.Items.Add("TEVES");
            cmbMonth.Items.Add("SHEVAT");
            cmbMonth.Items.Add("ADAR 1");
            cmbMonth.Items.Add("ADAR 2");
            cmbMonth.Items.Add("NISSAN");
            cmbMonth.Items.Add("IYAR");
            cmbMonth.Items.Add("SIVAN");
            cmbMonth.Items.Add("TAMUZ");
            cmbMonth.Items.Add("AV");
            cmbMonth.Items.Add("ELUL");


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Closes Search Form


            if (!IsAMonth())
            {
                MessageBox.Show("Please Select A Month From The Drop-Down Menu");
            }

            else if (!IsGoodYear())
            {
                MessageBox.Show("Please Enter A Year Between 3762 And 13759");
            }

            else
            {

                Close();
            }
        }

        public string GetMonthSearch()
        {
            //Retruns Seached Month

            return cmbMonth.Text;
        }

        public string GetYearSearch()
        {
            //Retruns Seached Year

            return txtYear.Text;
        }

        public bool IsAMonth()
        {
            // checks if input month is correct

            List<string> Year = new List<string>();

            Year.Add("TISHREI");
            Year.Add("CHESHVAN");
            Year.Add("KISLEV");
            Year.Add("TEVES");
            Year.Add("SHEVAT");
            Year.Add("ADAR 1");
            Year.Add("ADAR 2");
            Year.Add("NISSAN");
            Year.Add("IYAR");
            Year.Add("SIVAN");
            Year.Add("TAMUZ");
            Year.Add("AV");
            Year.Add("ELUL");


            for (int i = 0; i < Year.Count; i++)
            {
                if (cmbMonth.Text.ToUpper() == Year[i])
                {
                    return true;
                }
            }
            
            return false;

        }

        public bool IsGoodYear()
        {
            // checks if input year is correct
            int year;

            if (txtYear.Text == "" || !int.TryParse(txtYear.Text, out year) || int.Parse(txtYear.Text) <= 3761 || int.Parse(txtYear.Text) >= 13760 )
            {
                return false;
            }

            return true;
        }

    }
}
