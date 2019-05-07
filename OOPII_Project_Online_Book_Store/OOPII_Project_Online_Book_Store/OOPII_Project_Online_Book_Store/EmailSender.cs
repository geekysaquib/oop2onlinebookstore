using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace OOPII_Project_Online_Book_Store
{
    class EmailSender
    {
        
        
            static string smtpAddress = "smtp.gmail.com";
            static int portNumber = 587;
            static bool enableSSL = true;
            static string emailFromAddress = "sabri1905sabri@gmail.com"; //Sender Email Address  
            static string password = "BoraMuratAnıl"; //Sender Password    
            static string subject = "Şifre Hatırlatma";
            
           
            public static void SendEmail(Customer customer)
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(customer.Email);
                    mail.Subject = subject;
                    mail.Body = "merhaba"+customer.Username+" şifren "+customer.Password;
                    mail.IsBodyHtml = true;
                    //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
            }
        }
    }

