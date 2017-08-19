using Projekt.DAL;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class ProjektApp : Form
    {
        private readonly ClientDb _db;
        
      


        public ProjektApp()
        {
            InitializeComponent();
            
            ConfigureControls();
            _db = new SqlServerDb();
            LoadData();
            

        }
        private void ConfigureControls()
        {
            ClientsDataGridView.AutoGenerateColumns = false;
           
        }
        private void LoadData()
        {
            ClientsDataGridView.DataSource = _db.GetClient();
            
             DiscountDataGridView.DataSource = _db.GetRabat();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wyświetlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Autorem tej aplikacji jest Piotr Kotowski\n Aplikacja została stworzona na potrzeby projektu APBD ", "O Autorze");
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void googleChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "http:\\www.google.pl");

        }

        private void wAplikacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OpenAppBrowser().Show();
        }

        private void ClientsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            var selectedClient = ClientsDataGridView.Rows[e.RowIndex].DataBoundItem as Client;
            if (selectedClient == null)
            {
                MessageBox.Show("Prosze wybrac jeden z dostepnych");
                return;
            }
            int newClientId = _db.UpdateClient(selectedClient);
            if (newClientId > 0)
            {
                selectedClient.ClientId = newClientId;
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newClient = new Client();
            var clients = _db.GetClient();
            clients.Add(newClient);
            ClientsDataGridView.DataSource = clients;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ClientToDelete = ClientsDataGridView.SelectedRows[0].DataBoundItem as Client;
            _db.DeleteClient(ClientToDelete);
            ClientsDataGridView.DataSource = _db.GetClient();

        }

        private void ClientsDataGridView_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hitTest = ClientsDataGridView.HitTest(e.X, e.Y);
                    ClientsDataGridView.ClearSelection();
                    ClientsDataGridView.Rows[hitTest.RowIndex].Selected = true;
                }
            }catch
            {

            }
        }

        private void PrzyznajRabatButton_Click(object sender, EventArgs e)
        {
            new EditForm(1).Show();
        }
    }
}
