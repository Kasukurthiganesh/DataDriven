using AventStack.ExtentReports;
using MakeMyTrip.PageObjects;
using MakeMyTrip.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTrip.Tests
{

    public class LoginPage_Test : Base
    {
        [Parallelizable]
        [Test]
        [Category("Login Tests"), Category("Smoke")]
        public void loginpage()
        {
            LoginPage lp = new LoginPage(getDriver());
            Homepage hp = new Homepage(getDriver());
            Thread.Sleep(5000);
            test = extent.CreateTest("Login Test").AssignCategory("Functional Tests");
            //  hp.getpopup();
            Thread.Sleep(3000);
            lp.Login_CreateAccount();
            lp.MyBizAccount();
            Console.WriteLine(lp.Login_SignUpText());
            lp.Forgot_LoginId();
            lp.ContinueMyBizAccount();
            lp.EnterYourWorkEmailId("lovesganesh@gmail.com");
            //   lp.ContinueMyBizAccount();
            Console.WriteLine(lp.UseYourBussinessAccountText());
            lp.GoogleAccount();
            lp.Term_Condition();
            lp.Privacy();
            lp.PersonalAccount();
            Console.WriteLine(lp.Email_MobileNumberText());
            lp.Email_ContinueButton();
            lp.EnterEmail_MobileNumber("lovesganesh8@gmail.com");
            lp.Email_ContinueButton();
            lp.back_Button();
            lp.Email_ContinueButton();
            Console.WriteLine(lp.LoginWithPasswordText());
            Console.WriteLine(lp.Passwordtext());
            lp.RestPassword();
            //  lp.LoginPageButton();
            //  Console.WriteLine(lp.ErrorMessagePleaseEnterPass());
            lp.PasswordEnter("Kganesh@22");
            test.Log(Status.Info, "Entered username and password");
            lp.LoginPageButton();
            test.Log(Status.Info, "Clicked login button");
            var screenshotPath = TakeScreenshot("LoginPage");
            test.AddScreenCaptureFromPath(screenshotPath, "LoginPage");
            Thread.Sleep(3000);
            string titleofPage = getDriver().Title;
            Console.WriteLine(titleofPage);
            // Log the test result using Extent Reports
            ExtentTest test1 = extent.CreateTest("Test Login");
            test1.Log(Status.Pass, "User logged in successfully");

        }
        [Parallelizable]
        [Test]
        [Category("Smoke")]
        public void Test2()
        {
            var screenshotPath = TakeScreenshot("Test2Screenshot");
            Console.WriteLine("Screenshot taken Smoke");
            String titile=getDriver().Title;
            Console.WriteLine(titile);

        }
        [Parallelizable]
        [Test]
        [Category("Regression")]
        public void Test3()
        {
            var screenshotPath = TakeScreenshot("Test3Screenshot");
            Console.WriteLine("Screenshot taken Regression");

        }
        [Parallelizable]
        [Test]
        [Category("Smoke")]
        public void Test4()
        {
            Console.WriteLine("Screenshot taken Smoke");

        }
    }
}
