using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Helpers
{
    class MailHelper
    {
        private static int port = 587;
        private static bool ssl = true;
        private static SmtpClient smtpClient;

        public MailHelper()
        {
           
            smtpClient = new SmtpClient("outlook.office365.com")
            {
                Port = port,
                Credentials = new NetworkCredential("clubmanagementmans@outlook.com", "75380MANS"),
                EnableSsl = ssl,
                Timeout = 1 * 20000,
            };
        }

        public  bool SendMail(string To, string DW, string UDW, string Tresc, string Temat, ref string _error)
        {
            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("clubmanagementmans@outlook.com", "ClubManagement"),
                    Subject = Temat,
                    Body = Tresc,
                    IsBodyHtml = false,
                };

                string[] odbiorcy;
                odbiorcy = To.Split(';');
                foreach (string odbiorca in odbiorcy)
                {
                    if (odbiorca.Replace(';', ' ').Trim() != "")
                    {
                        mailMessage.To.Add(odbiorca);
                    }
                }

                if (!string.IsNullOrEmpty(DW))
                {
                    string[] odbiorcyDW;
                    odbiorcyDW = DW.Split(';');
                    foreach (string odbiorcaDW in odbiorcyDW)
                    {
                        if (odbiorcaDW.Replace(';', ' ').Trim() != "")
                        {
                            mailMessage.CC.Add(odbiorcaDW);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(UDW))
                {
                    string[] odbiorcyUDW;
                    odbiorcyUDW = DW.Split(';');
                    foreach (string odbiorcaUDW in odbiorcyUDW)
                    {
                        if (odbiorcaUDW.Replace(';', ' ').Trim() != "")
                        {
                            mailMessage.Bcc.Add(odbiorcaUDW);
                        }
                    }
                }

                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                _error = "SendMail error: " + ex.ToString();
                return false;
            }
        }
    }
}
