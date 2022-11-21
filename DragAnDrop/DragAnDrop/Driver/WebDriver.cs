using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DragAnDrop.Driver
{
    public class WebDriver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialization()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            Instance.Navigate().GoToUrl("https://demoqa.com/droppable");

            


        }

        public static void CleanUp()
        {
            Instance?.Quit();
        }


    }
}
