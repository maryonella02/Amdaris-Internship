using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lesson2Tests
{
  class DisplayPizza
  {
    public void ClickToSeePizza(ChromeDriver driver)
    {
      var fungi = driver.FindElementsByXPath("//*[contains(@class,'in')]/..")[4];
      fungi.Click();

    }
    public void VerifyTExt(ChromeDriver driver, string expectedResult)
    {
      var actualResult = driver.FindElementsByXPath("//div[contains(text(),'Funghi')]/following-sibling::p")[2].Text;
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}
