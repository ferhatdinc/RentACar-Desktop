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
    public partial class frmMain : Form
    { 
        private Dictionary<Type, Form> ActiveForms;
        public static Boolean isLogin = false;
        
       
        public frmMain()
        {
            InitializeComponent(); 
            this.ActiveForms = new Dictionary<Type, Form>();
            this.ShowForm<Login>();
        }
        private void ShowForm<TSource>() where TSource : Form
        {
            Form form = null;
            if (this.ActiveForms.ContainsKey(typeof(TSource)))
            {
                form = this.ActiveForms[typeof(TSource)];
                form.WindowState = FormWindowState.Normal;
                form.Activate();
            }
            else
            {
                form = Activator.CreateInstance<TSource>();
                form.MdiParent = this;
                form.FormClosed += Form_FormClosed;
                form.Show();

                this.ActiveForms.Add(typeof(TSource), form);
            }
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ActiveForms.Remove(sender.GetType());
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<Login>();
        }

        private void ReservationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLogin)
                this.ShowForm<frmReservationDetails>();
            else MessageBox.Show("Giriş Yap");
        }

        private void ReservationRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.ShowForm<>
            MessageBox.Show("Yakında");
        }

        private void DoReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLogin)
                this.ShowForm<frmNewReservation>();
            else MessageBox.Show("Giriş Yap");
        }
    }
}
