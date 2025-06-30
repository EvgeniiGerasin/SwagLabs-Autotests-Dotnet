using OpenQA.Selenium;

namespace SwagLabs_Autotests_Dotnet;


class LoginPage : BasePage
{
    public void Login()
    {
        driver.FindElement(By.XPath(LocatorsLoginPage.input_login)).SendKeys(Config.Username);
        driver.FindElement(By.XPath(LocatorsLoginPage.input_password)).SendKeys(Config.Password);
        driver.FindElement(By.XPath(LocatorsLoginPage.button_enter));
    }

    public void CheckEnter()
    {
        Assert.That(driver.Url, Is.EqualTo(Config.Url + "/inventory.html"));
    }
}