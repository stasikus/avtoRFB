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
using OpenQA.Selenium.Interactions;

namespace avtoRFB
{
    class RegistrationTW
    {
        public static bool Register(string last_name, string name, string pass, string email)
        {
            Driver.Instance.Navigate().GoToUrl("https://twitter.com/");

            var registrationForm = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='front-signup js-front-signup']"), 1);
            if (registrationForm != null)
            {
                Driver.Instance.FindElement(By.XPath("//form[@id='frontpage-signup-form']/button[@class='btn signup-btn u-pullRight']")).Click(); // регистрация главная страница
                
                var registerNameLastName = Driver.Instance.FindElement(By.XPath("//div[@class='prompt name']/div[@class='field']/input[@name='user[name]']"));
                registerNameLastName.Clear();
                registerNameLastName.SendKeys(name + " " + last_name);

                var registerEmail = Driver.Instance.FindElement(By.XPath("//div[@class='prompt email']/div[@class='field']/input[@name='user[email]']"));
                registerEmail.Clear();
                registerEmail.SendKeys(email);

                var registerPass = Driver.Instance.FindElement(By.XPath("//div[@class='prompt password']/div[@class='field']/input[@name='user[user_password]']"));
                registerPass.Clear();
                registerPass.SendKeys(pass);

                Driver.Instance.FindElement(By.XPath("//div[@class='prompt select-username']/div[@class='suggestions']/ul/li[last()]/button")).Click(); // выбрать ник
                Driver.Instance.FindElement(By.XPath("//div[@class='prompt rememberme']/label[@class='t1-label checkbox']/input[@name='user[remember_me_on_signup]']")).Click(); //снять галочки "запомнить"
                Driver.Instance.FindElement(By.XPath("//div[@class='prompt optin']/label[@class='t1-label']/input[@name='user[use_cookie_personalization]']")).Click(); //снять галочки "запомнить"
                Driver.Wait(1);
                Driver.Instance.FindElement(By.XPath("//div[@class='scroller']")).Click();
                Driver.Wait(1);
              //  Driver.Instance.FindElement(By.XPath("//div[@class='sign-up-box']")).Click(); //регистрация

                var submit = Driver.Instance.FindElement(By.XPath("//div[@class='doit']")); //регистрация
                Actions builder = new Actions(Driver.Instance);
                builder.ClickAndHold(submit).Release().Build().Perform();

               // Driver.Instance.FindElement(By.XPath("//div[@class='sign-up-box']")).Click(); //регистрация

                var someElseForm = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='container u-textCenter']"), 3);
                if (someElseForm != null)
                {
                    Driver.Instance.FindElement(By.XPath("//div[@id='doc']//a[last()]")).Click(); //если после регистрации будет блок с непонятными сообщениями
                    Driver.Instance.Navigate().GoToUrl("https://twitter.com/");
                    Driver.Instance.FindElementAndWait(By.XPath("//div[@id='timeline']"), 3); //ждем пока загрузится страница

                    Driver.Instance.FindElement(By.XPath("//div[@class='pull-right']/ul[@class='nav right-actions']/li[@id='user-dropdown']/a[@id='user-dropdown-toggle']")).Click(); //для выхода с аккаунта
                    Driver.Instance.FindElement(By.XPath("//div[@class='dropdown-menu']/ul[@role='menu']/li[@id='signout-button']")).Click();
                }
                else
                {
                    Driver.Instance.FindElement(By.XPath("//div[@class='pull-right']/ul[@class='nav right-actions']/li[@id='user-dropdown']/a[@id='user-dropdown-toggle']")).Click(); //для выхода с аккаунта
                    Driver.Instance.FindElement(By.XPath("//div[@class='dropdown-menu']/ul[@role='menu']/li[@id='signout-button']")).Click();
                }

                return true;
            }
            else
            {
                // Driver.Instance.Close();
                return false;
            }
        }

        public static string NextRegistrationStep()
        {
            // Driver.Instance.FindElement(By.XPath("//div[@class='sign-up-box']")).Click();

            string twitterNick = Driver.Instance.FindElement(By.Id("username")).GetAttribute("value");
            return twitterNick;
        }

        public static bool isRegisted()
        {
            var isRegistedCheck = Driver.Instance.FindElementAndWait(By.XPath("//div[@class='page-canvas']"), 1);
            if (isRegistedCheck != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		
    }
}
