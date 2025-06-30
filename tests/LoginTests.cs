namespace SwagLabs_Autotests_Dotnet;

using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;


[TestFixture]
public class LoginTests : BasePage
{

    [Test]
    public void SuccessfulLogin_WithStandardUser()
    {
        var login_task = new LoginPage();
        login_task.Login();
        login_task.CheckEnter(); 
    }

}
