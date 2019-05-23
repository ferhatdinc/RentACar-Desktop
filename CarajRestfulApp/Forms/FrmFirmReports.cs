using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarajRestfulApp.Forms
{
    public partial class FrmFirmReports : Form
    {
        public FrmFirmReports()
        {
            InitializeComponent();
        }

        private void FrmFirmReports_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient()) //Fix
            {
                string[] month = new string[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
                client.BaseAddress = new Uri("http://165.22.91.48/api/"); //Fix
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Fix
                HttpResponseMessage response = client.GetAsync("company/economicreport?CompanyID=" + int.Parse(FrmMain.RCompany.CompanyID.ToString())).Result;
                //End Point Name https://localhost:44300/car/getcars Query String Example bla bla car/getcars?blabla
                if (response.IsSuccessStatusCode)
                {
                    var model = response.Content.ReadAsAsync<JArray>().Result;
                    for (int i = 0; i < month.Length; i++)
                    {
                        chrtIncome.Series["Gelir"].Points.AddXY(month[i], decimal.Parse(model[i]["income"].ToString()));
                        chrtCars.Series["Cars"].Points.AddXY(month[i], float.Parse(model[i]["monthlyCarRental"].ToString()));
                        chrtKM.Series["Cars"].Points.AddXY(month[i], float.Parse(model[i]["monthlyCarExceedKM"].ToString()));
                    }


                }
            }
        }
    }
}
