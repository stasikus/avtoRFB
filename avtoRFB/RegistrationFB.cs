using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using xNet.Net;
using xNet.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace avtoRFB
{
    class RegistrationFB
    {
        public static bool Register(string last_name, string name, string pass, string email)
        {
          /*  Driver.Instance.Navigate().GoToUrl("http://facebook.com/");

            var registrationForm = Driver.Instance.FindElementAndWait(By.Id("registration_container"), 1);
            if (registrationForm != null)
            {
                var registerName = Driver.Instance.FindElement(By.Id("u_0_1"));
                registerName.Clear();
                registerName.SendKeys(name);

                var registerLastName = Driver.Instance.FindElement(By.Id("u_0_3"));
                registerLastName.Clear();
                registerLastName.SendKeys(last_name);

                var registerEmail = Driver.Instance.FindElement(By.Id("u_0_5"));
                registerEmail.Clear();
                registerEmail.SendKeys(email);

                var registerEmailAgain = Driver.Instance.FindElement(By.Id("u_0_8"));
                registerEmailAgain.Clear();
                registerEmailAgain.SendKeys(email);

                var registerPass = Driver.Instance.FindElement(By.Id("u_0_a"));
                registerPass.Clear();
                registerPass.SendKeys(pass);

                Driver.Wait(1);

                Random random = new Random();
                int randomDay = random.Next(1, 29);
                int randomMonth = random.Next(1, 12);
                int randomYear = random.Next(1960, 2000);
                int randomSex = random.Next(1, 2);

                Driver.Instance.FindElement(By.XPath("//span[@id='u_0_c']/span/select[@id='day']/option[@value='" + randomDay + "']")).Click();
                Driver.Wait(1);
                Driver.Instance.FindElement(By.XPath("//span[@id='u_0_c']/span/select[@id='month']/option[@value='" + randomMonth + "']")).Click();
                Driver.Wait(1);
                Driver.Instance.FindElement(By.XPath("//span[@id='u_0_c']/span/select[@id='year']/option[@value='" + randomYear + "']")).Click();

                if (randomSex == 1)
                    Driver.Instance.FindElement(By.XPath("//span[@id='u_0_g']/span[@class='_5k_2 _5dba']/input[@id='u_0_d']")).Click();
                else
                    Driver.Instance.FindElement(By.XPath("//span[@id='u_0_g']/span[@class='_5k_2 _5dba']/input[@id='u_0_e']")).Click();


                Driver.Instance.FindElement(By.XPath("//div[@class='clearfix']/button[@id='u_0_i']")).Click();

                var registrationFormCheck = Driver.Instance.FindElementAndWait(By.XPath("//form[@class='checkpoint']"), 10);
                if (registrationFormCheck != null)
                {
                    Driver.Instance.FindElement(By.XPath("//table[@class='uiGrid _51mz uiOverlayFooterGrid']/tbody/tr[@class='_51mx']/td[@class='_51m- uiOverlayFooterButtons _51mw']/button")).Click();
                    Driver.Instance.FindElement(By.XPath("//div[@class='rfloat _ohf']")).Click();
                    return true;
                }
                else
                {
                    var registrationFormError = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='uiStepList']"), 6);
                    if (registrationFormError != null)
                    {
                        Driver.Instance.FindElement(By.XPath("//div[@class='rfloat _ohf']/ul[@id='pageNav']/li[@id='navAccount']")).Click();
                        Driver.Instance.FindElement(By.XPath("//div[@id='userNavigation']/ul/li[@role='menuitem']/form[@id='logout_form']")).Click();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
           * */
            return true;
        }
    }
}
