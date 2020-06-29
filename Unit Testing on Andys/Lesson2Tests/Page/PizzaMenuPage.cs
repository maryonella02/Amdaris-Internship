using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Lesson2Tests
{
  class PizzaMenuPage
  { public void ClickToOrderPizza(ChromeDriver driver)
    {
     var orderEl = driver.FindElementByXPath("//a[contains(text(),'Оrder')]");
      var timeout = TimeSpan.FromSeconds(5);

      WebDriverWait wait = new WebDriverWait(driver, timeout);
      var order = wait.Until(condition: ExpectedConditions.ElementToBeClickable(orderEl));
      orderEl.Click();
    }
  }
}
