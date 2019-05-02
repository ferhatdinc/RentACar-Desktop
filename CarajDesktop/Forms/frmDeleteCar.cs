using CarajDesktop.CarService;
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
    public partial class frmDeleteCar : Form
    {
        public frmDeleteCar()
        {
            
            InitializeComponent();
        }
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            using (var carClient = new CarServiceSoapClient())
            {
                int x = int.Parse(dgwCarList.SelectedRows[0].Cells[0].Value.ToString());
                carClient.DeleteCar(x);
                MessageBox.Show("Car Deleted");
            }
        }
        private void frmDeleteCar_Load(object sender, EventArgs e)
        {
            using (var carClient = new CarServiceSoapClient())
            {
                var cars = carClient.GetCars(frmMain.Company.CompanyID);
                dgwCarList.DataSource = cars;
                carClient.Close();
            }
        }
    }
}
