using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
        }

        public EditForm(int i)
        {
            InitializeComponent();
            label1.Text = i.ToString();
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            {
                    
                 
                 using (var sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
                 {
                    var sqlCommand = new SqlCommand("UPDATE Client SET RABAT =" + DiscountComboBox.SelectedValue + " WHERE ClientId =" + label1.Text,sqlCon);

                     sqlCon.Open();

                     var dr = sqlCommand.ExecuteReader();
                     
                     dr.Dispose();
                 }
            }


            var fromAddress = new MailAddress("apbdtesttt@gmail.com", "APBD TEST");
            var toAddress = new MailAddress("s13830@pjwstk.edu.pl");
            const string fromPassword = "Projekt APBD";
            const string subject = "RABAT";
            const string body = "Gratulacje, otrzymałeś rabat 10 %";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}