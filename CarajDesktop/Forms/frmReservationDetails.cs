using CarajDesktop.CarService;
using CarajDesktop.CompanyService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarajDesktop.Forms
{
    public partial class FrmReservationDetails : Form
    {
        public FrmReservationDetails()
        {
            InitializeComponent();
        }

        private void BtnReservationsList_Click(object sender, EventArgs e)
        {
              
        }

        private void FrmReservationDetails_Load(object sender, EventArgs e)
        {
            using (var CompanyService = new CompanyServiceSoapClient())
            {
                var response = CompanyService.GetRentDetails(frmMain.Company.CompanyID);
                dgwRezervtions.DataSource = response;
                CompanyService.Close();
            }
        }
    }
}
