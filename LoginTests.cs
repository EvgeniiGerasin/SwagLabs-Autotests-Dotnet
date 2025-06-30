namespace SwagLabs_Autotests_Dotnet;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


[TestFixture]
public class LoginTests : BasePage
{

    [Test]
    public void SuccessfulLogin_WithStandardUser()
    {
        var username = "standard_user";
        var password = "secret_sauce";
        var url = "https://www.saucedemo.com/";

        driver.Navigate().GoToUrl(url);
        driver.FindElement(By.Id("user-name")).SendKeys(username);
        driver.FindElement(By.Id("password")).SendKeys(password);
        driver.FindElement(By.Id("login-button")).Click();

        Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
    }

}
