
namespace SwagLabs_Autotests_Dotnet;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


public class BasePage
{
    protected IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(Config.Url);
    }

    [TearDown]
    public void TearDown()
    {
        driver.Dispose();
    }    
    
}