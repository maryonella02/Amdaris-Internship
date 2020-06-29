using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Lesson2Tests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void PizzaMenuTest()
    {
      var driver = new ChromeDriver();
      
      var mainPage = new AndysMainPage(); 
      driver.Navigate().GoToUrl("https://www.andys.md/en");
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
      mainPage.ClickAndysPizzaPage(driver);
      System.Threading.Thread.Sleep(2000);
      driver.Quit();
    }
    [TestMethod]
    public void DisplayPizza()
    {
      var driver = new ChromeDriver();
      var mainPage = new AndysMainPage();
      var fungiPage = new DisplayPizza();
      var ver = new DisplayPizza();
      driver.Navigate().GoToUrl("https://www.andys.md/en");
      mainPage.ClickAndysPizzaPage(driver);
      fungiPage.ClickToSeePizza(driver);
      ver.VerifyTExt(driver, "Cream, mushrooms Champignons, Mozzarella, chicken fillet, truffle oil.");
     WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    var vis = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[@id='light_window']/div/div/div/div/div[2]/p")));

     driver.Quit();

    }
    [TestMethod]
    public void OrderPizzaTest()
    {
      var driver = new ChromeDriver();
      var mainPage = new AndysMainPage();
      var pizzaPage = new PizzaMenuPage();
     
      driver.Navigate().GoToUrl("https://www.andys.md/en");
      mainPage.ClickAndysPizzaPage(driver);
      pizzaPage.ClickToOrderPizza(driver);

     
      WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
      var vis = wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[contains(@class,'ands_preview menuelem rowindex1 ands_zakaz_view')]/..")));
      var invis = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[contains(@class,'ands_preview menuelem rowindex1 ands_zakaz_view')]/..")));
      driver.Quit();
    } 
  }
}
