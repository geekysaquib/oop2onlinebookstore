using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace OOPII_Project_Online_Book_Store
{
    /*\class EmailSender
* \brief Müsterilerin email adresleriyle iletisime gecen siniftir.
*
*/
    class EmailSender
    {

        public static void SendEmail(Customer customer)
        {


            MailMessage msj = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("onlinebookstore26@outlook.com", "BoraMuratAnil");
            client.Port = 587;
            client.Host = "smtp-mail.outlook.com";
            client.EnableSsl = true;

            msj.To.Add(customer.Email);
            msj.From = new MailAddress("onlinebookstore26@outlook.com", "BoraMuratAnil");
            msj.Subject = "parola hatırlatma";
            msj.Body = "merhaba " + customer.Username + " şifreniz " + customer.Password;
            client.Send(msj);
        }
        public static void SendEmail(Customer customer, ShoppingCart shopping)
        {

            MailMessage msj = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("onlinebookstore26@outlook.com", "BoraMuratAnil");
            client.Port = 587;
            client.Host = "smtp-mail.outlook.com";
            client.EnableSsl = true;
            string message = "";
            foreach (ItemtoPurchase item in shopping.itemstoPurchase)
            {
                message += item.Product.Name + "  adlı üründen " + item.Quantity + " kadar sipariş ettiniz." + "\n";
            }
            message += "Total tutar" + " " + shopping.PaymentAmount.ToString() + " TL";
            msj.To.Add(customer.Email);
            msj.From = new MailAddress("onlinebookstore26@outlook.com", "BoraMuratAnil");
            msj.Subject = "Fatura";
            msj.Body = message;
            client.Send(msj);


        }
        public static void SendEmail(Customer customer, string bidding)
        {

            MailMessage msj = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("onlinebookstore26@outlook.com", "BoraMuratAnil");
            client.Port = 587;
            client.Host = "smtp-mail.outlook.com";
            client.EnableSsl = true;
          
           
            msj.To.Add(customer.Email);
            msj.From = new MailAddress("onlinebookstore26@outlook.com", "BoraMuratAnil");
            msj.Subject = "Fatura";
            msj.Body = bidding;
            client.Send(msj);


        }
    }
}

