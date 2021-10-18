using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NPO10
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestITechArt()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/search?q=" + "ITechArt");
            Console.WriteLine(driver.Title.ToLower().Contains("ITechArt".ToLower()) ? 
                "Название вкладки содержит слово ITechArt" :
                "Название вкладки НЕ содержит слово ITechArt");
            
            var firstSearchResult = driver.FindElement(By.Id("search")).FindElement(By.XPath(".//a")).Text;
            Console.WriteLine(firstSearchResult.ToLower().Contains("ITechArt".ToLower()) ?
                "Первый поисковый результат содержит слово ITechArt" : 
                "Первый поисковый результат НЕ содержит слово ITechArt");
            driver.Close();
        }
        
    }
}