using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CarajRestfulApp.Forms
{
    public partial class FrmReservationDetails : Form
    {
        public FrmReservationDetails()
        {
            InitializeComponent();
        }

        private void btnReservationsList_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                HttpResponseMessage response = client.GetAsync("company/GetRentDetails?CompanyID=" + int.Parse(FrmMain.RCompany.CompanyID.ToString())).Result;
                //End Point Name https://localhost:44300/car/getcars Query String Example bla bla car/getcars?blabla
                if (response.IsSuccessStatusCode)
                {
                    var model = response.Content.ReadAsAsync<JArray>().Result;
                    dgwRezervtions.DataSource = model;
                }
            }
        }

        private void FrmReservationDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
