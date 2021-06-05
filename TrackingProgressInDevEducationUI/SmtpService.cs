using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows;
using static TrackingProgressInDevEducationUI.Defines;

namespace TrackingProgressInDevEducationUI
{
    public class SmtpService
    {
        public int SmtpRun(Dictionary<string, string> param)
        {
            var gen = new GenVerification();
            int key = gen.GenerateKey();
            try
            {
                MailMessage mail = new()
                {
                    From = new MailAddress(From),
                    Subject = $"{Registration}",
                    Body = $"{Welcome}{Gap}{param["FullName"]}{NewLine}{VerifyRegistr}{NewLine}{key}"
                };
                mail.To.Add(param["Email"]);
                SmtpClient client = new()
                {
                    Host = Host,
                    Port = Port,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(Email, Password)
                };
                client.Send(mail);
            }
            catch (FormatException)
            {
                MessageBox.Show($"{Defines.FormatException}");
                key = -1;
                
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"{Defines.ArgumentException}");
                key = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{NewLine}{ExeptionEx}");
                key = -1;
            }
            return key;
        }
    }
}