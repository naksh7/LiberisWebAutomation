using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace LiberisWeb.Drivers
{
    public class Utils
    {
        public static IWebDriver driver;
        static string url = "https://www.liberis.com/";

        public static IWebDriver getDriver()
        {
            driver = new ChromeDriver(getChromeDriverPath());
            driver.Url = url;
            return driver;
        }
        
        public static void closeDriver()
        {
            driver.Close();
        }
        private static string getChromeDriverPath()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            return projectDirectory + "\\Drivers";
        }
        public static List<string> StringSplitter(string typeOfPartners)
        {
            return typeOfPartners.Split(',').ToList();
        }
    }
}
