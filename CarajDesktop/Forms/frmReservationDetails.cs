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
    public partial class frmReservationDetails : Form
    {
        public frmReservationDetails()
        {
            InitializeComponent();
        }

        private void btnReservationsList_Click(object sender, EventArgs e)
        {
            var carClient = new CarServiceSoapClient(); 
            var companyClient = new CompanyServiceSoapClient();
            var response = carClient.GetCars(1);
            dgwRezervtions.DataSource = response;
            companyClient.Close();
        }     
       
    }
}
