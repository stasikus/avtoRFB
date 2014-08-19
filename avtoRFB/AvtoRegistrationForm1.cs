using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoRFB
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public string path = Directory.GetCurrentDirectory();
        Thread newThread;
        Net http = new Net(); //Создаем объект
        string html = "";

        private void start_btnFB_Click(object sender, EventArgs e)
        {
            string format = FBpanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            newThread = new Thread(() => Create(Convert.ToInt32(quentity_boxFB.Value), "FB", format));
            newThread.IsBackground = true;
            newThread.Start();
        }

        private void start_btnTW_Click(object sender, EventArgs e)
        {
                string format = TWpanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                newThread = new Thread(() => Create(Convert.ToInt32(quentity_boxTW.Value), "TW", format));
                newThread.IsBackground = true;
                newThread.Start();
        }

        void Create(int accounts, string site, string format)
        {
            bool flag = false;
            try
            {
                for (int i = 0; i < accounts; i++)
                {
                    string generate_name = GenerateNameLastNamePass.Name(path + "\\name.txt");
                    string generate_last_name = GenerateNameLastNamePass.LastName(path + "\\lastname.txt");
                    string generate_pass = GenerateNameLastNamePass.Password(generate_name, generate_last_name);
                    string generate_email = GenerateEmail.Email(generate_name, generate_last_name);

                    
                    if (site == "FB")
                    {
                        string html = http.GetHtml("https://www.facebook.com/", "", "https://www.facebook.com/");
                        flag = RegistrationFB.Register(generate_last_name, generate_name, generate_pass, generate_email);

                        string lsd = html.Remove(0, html.IndexOf("{\"token\":\"") + 10);
                        lsd = lsd.Substring(0, lsd.IndexOf("\""));
                        string reg_instance = html.Remove(0, html.IndexOf("reg_instance\" value=\"") + 21);
                        reg_instance = reg_instance.Substring(0, reg_instance.IndexOf("\""));
                        string captcha_persist_data = html.Remove(0, html.IndexOf("captcha_persist_data\" value=\"") + 29);
                        captcha_persist_data = captcha_persist_data.Substring(0, captcha_persist_data.IndexOf("\""));
                        string captcha_session = html.Remove(0, html.IndexOf("captcha_session\" value=\"") + 24);
                        captcha_session = captcha_session.Substring(0, captcha_session.IndexOf("\""));
                        string revision = html.Remove(0, html.IndexOf("revision\"") + 11);
                        revision = revision.Substring(0, revision.IndexOf(","));
                        string extra_challenge_params = html.Remove(0, html.IndexOf("extra_challenge_params\" value=\"") + 31);
                        extra_challenge_params = extra_challenge_params.Substring(0, extra_challenge_params.IndexOf("\""));

                        string post = "lsd=" + lsd + "&firstname=" + generate_name + "&lastname=" + generate_last_name + "&reg_email__=" + generate_email + "&reg_email_confirmation__=" + generate_email + "&reg_passwd__=" + generate_pass + "&birthday_day=11&birthday_month=8&birthday_year=1990&sex=2&referrer=&asked_to_login=0&terms=on&ab_test_data=&contactpoint_label=email_only&locale=ru_RU&abtest_registration_group=1&reg_instance=" + reg_instance + "&captcha_persist_data=" + captcha_persist_data + "&captcha_session=" + captcha_session + "&extra_challenge_params="+extra_challenge_params+"&recaptcha_type=password&captcha_response=&ignore=captcha&__user=0&__a=1&__dyn=&__req=6&__rev="+revision+"";
                        string htmlResp = http.PostRegistration("https://www.facebook.com/ajax/register.php", post, "https://www.facebook.com/");
                        //captcha_persist_data\" value=\"
                        if (flag)
                        {
                            FBcounter_label.BeginInvoke((Action)delegate
                            {
                                FBcounter_label.Text = (i + 1).ToString();
                                richTextBoxFB.Text = generate_name + " " + generate_last_name + " " + generate_email + " " + generate_pass;
                            });
                            WriteToFile.Writer(path, site, format, generate_name, generate_last_name, generate_email, generate_pass);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (site == "TW")
                    {
                        flag = RegistrationTW.Register(generate_last_name, generate_name, generate_pass, generate_email);
                        if (flag)
                        {
                            TWcounter_label.BeginInvoke((Action)delegate
                            {
                                TWcounter_label.Text = (i + 1).ToString();
                            });
                            WriteToFile.Writer(path, site, format, generate_name, generate_last_name, generate_email, generate_pass);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    System.Threading.Thread.Sleep(200);
                    
                }
                MessageBox.Show("Creating accounts for " + site + " finished");
            }
            catch (Exception)
            {
                MessageBox.Show("File doesn't exist or empty");
            }
            
        }

        
    }
}
