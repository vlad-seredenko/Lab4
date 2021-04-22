using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTown_Click(object sender, EventArgs e)
        {
            
                Town town = new Town();
                fTown ft = new fTown(town);
            if (ft.ShowDialog() == DialogResult.OK)

            {
                tbTownsInfo.Text +=
                (town.Name, town.Country, town.Region,
                ".Мешканців:", town.Population,".Річний дохід:", town.YearIncome,".Площа:", town.Square,
                town.HasPort ? "Є порт" : "Немає порта",
                town.HasAirport ? "Є аеропорт" : "Немає аеропорта",
                ".Річний дохід мешканця:", town.GetYearIncomePerInhabitant(), "\r\n");

                }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            Application.Exit();

        }

        private void tbTownsInfo_TextChanged(object sender, EventArgs e)
        {

        }
}   }   

