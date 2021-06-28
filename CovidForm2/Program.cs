using System;
using System.Threading;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CovidForm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amstel-doors.com/covid19/");

            Thread.Sleep(2000); // allow webpage to load


            // Association feild
            new SelectElement(driver.FindElement(By.Name("input_12"))).SelectByText("Office Employee"); 

            //FirstName
            IWebElement NameTextBox = driver.FindElement(By.Id("input_3_8_3"));
            NameTextBox.Clear();
            NameTextBox.SendKeys("Ben");

            //LastName
            IWebElement LastNameTextBox = driver.FindElement(By.Id("input_3_8_6"));
            LastNameTextBox.Clear();
            LastNameTextBox.SendKeys("Bowcott");

            //Phone
            IWebElement PhoneTb = driver.FindElement(By.Id("input_3_9"));
            PhoneTb.Clear();
            PhoneTb.SendKeys("6479923380");


            //CompanyName
            IWebElement Company = driver.FindElement(By.Id("input_3_19"));
            Company.Clear();
            Company.SendKeys("Amstel");

            //Outside Canada
            IWebElement OutsideCanada = driver.FindElement(By.Id("choice_3_5_2"));
            OutsideCanada.Click();

            //Outside Canada
            IWebElement Sympotoms = driver.FindElement(By.Id("choice_3_7_2"));
            Sympotoms.Click();

            //Outside Canada
            IWebElement Sympotoms2 = driver.FindElement(By.Id("choice_3_13_2"));
            Sympotoms2.Click();

            //Isolate
            IWebElement Isolate = driver.FindElement(By.Id("choice_3_14_2"));
            Isolate.Click();

            //Contact
            IWebElement Contact = driver.FindElement(By.Id("choice_3_15_2"));
            Contact.Click();

            //Workplaces
            IWebElement Workplaces = driver.FindElement(By.Id("choice_3_16_2"));
            Workplaces.Click();

            //Truth
            IWebElement Truth = driver.FindElement(By.Id("choice_3_18_1"));
            Truth.Click();

            //button click
            IWebElement submit = driver.FindElement(By.Id("gform_submit_button_3"));
            submit.Click();
            
        }
    }
}
