using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace COVIDealer
{
    public partial class NewsTab : UserControl
    {
        public NewsTab()
        {
            InitializeComponent();
            //getText();



        }

        private void NewsTab_Load(object sender, EventArgs e)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver(driverService);

            driver.Navigate().GoToUrl("https://covid19.gov.vn/timelinelist/1711565/1.htm");

            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div/h2/a"));
            richTextBox1.Text = element.Text;
            //((ChromeDriver)driver).LaunchApp("");
            driver.Quit();
        }
        
    }
}
