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
  class AndysMainPage
  {
    public void ClickAndysPizzaPage(ChromeDriver driver)
    {
      var element = driver.FindElementsByLinkText("Pizza")[1];
      element.Click();


    }
  }
}
