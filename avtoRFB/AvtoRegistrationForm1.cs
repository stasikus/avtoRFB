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
            Driver.Initialize();
            DriverWait.Initialize(10);
        }
        public string path = Directory.GetCurrentDirectory();
        Thread newThread;

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
                        flag = RegistrationFB.Register(generate_last_name, generate_name, generate_pass, generate_email);
                        if (flag)
                        {
                            FBcounter_label.BeginInvoke((Action)delegate
                            {
                                FBcounter_label.Text = (i + 1).ToString();
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
