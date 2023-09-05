using MakeMyTrip.Action_Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Action=MakeMyTrip.Action_Driver.Action;

namespace MakeMyTrip.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//li[@data-cy='account']")]
        private IWebElement _Loginbutton;
        [FindsBy(How = How.XPath, Using = "//input[@id='username']")]
        private IWebElement _Email;
        [FindsBy(How = How.XPath, Using = "//button[@data-cy='continueBtn']")]
        private IWebElement _Email_Continue;
        [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
        private IWebElement _Password;
        [FindsBy(How = How.XPath, Using = "//*[@for='password']")]
        private IWebElement _PasswordText; 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Reset Password')]")]
        private IWebElement _ResetPassword;
        [FindsBy(How = How.XPath, Using = "//button[@data-cy='login']")]
        private IWebElement _login;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'or Login via OTP')]")]
        private IWebElement _Login_Via_OTP;
        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/section[1]/div[2]/p[1]/span[1]")]
        private IWebElement _LoginWithPasswordText;   
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Back')]")]
        private IWebElement _back;
        [FindsBy(How = How.XPath, Using = "//label[@for='username']")]
        private IWebElement _Email_MobileNumber_Text;
        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Personal Account')]")]
        private IWebElement _Personal_account;
        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'MyBiz Account')]")]
        private IWebElement _MyBiz_Account;
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Login/Sign up')]")]   
        private IWebElement _login_signupText;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Forgot Login Id?')]")]
        private IWebElement _forgot_login_Id;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter your work email id']")]
        private IWebElement _Enter_Work_Email;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'CONTINUE')]")]
        private IWebElement _continue_button;
        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'OR USE YOUR BUSINESS ACCOUNT WITH')]")]
        private IWebElement _userYourBussiness_account;
        [FindsBy(How = How.XPath, Using = "//div[@class='g_id_signin']")]
        private IWebElement _google_Id_signIn;
        [FindsBy(How = How.LinkText, Using = "T&Cs")]
        private IWebElement _TermAgreeement;
        //https://www.makemytrip.com/legal/in/eng/user_agreement.html
        [FindsBy(How = How.LinkText, Using = "Privacy")]
        private IWebElement _Privacy;
        //https://www.makemytrip.com/legal/privacy_policy.html
        [FindsBy(How = How.XPath,Using = "//*[@id='SW']/div[1]/div[2]/div[2]/section/form/div[1]/p[2]")]
        private IWebElement _Error_PleaseEnterPassword;
        
        [FindsBy(How = How.XPath, Using = "//button[@data-cy='login']")]
        private IWebElement _LoginPageButton;
        Action action = new Action();

        public void Login_CreateAccount()
        {
            action.HighLighterMethod(driver, _Loginbutton);
            action.Click(driver, _Loginbutton);
        }
        public void MyBizAccount()
        {
            action.HighLighterMethod(driver, _MyBiz_Account);
            action.Click(driver, _MyBiz_Account);
        }
        public string Login_SignUpText()
        {
            action.HighLighterMethod(driver, _login_signupText);
              return _login_signupText.Text;      
        }
        public void Forgot_LoginId()
        {
            action.HighLighterMethod(driver, _forgot_login_Id);
            action.IsElementEnabled(driver, _forgot_login_Id);
        }
        public bool ContinueMyBizAccount()
        {
            action.HighLighterMethod(driver, _continue_button);
            if(_continue_button.Enabled == true)
            {
                action.Click(driver, _continue_button);
            }
            else
            {
                Console.WriteLine("Continue button is Disabled");
                
            }
            return false;
        }
        public void EnterYourWorkEmailId(string Text)
        {
            action.HighLighterMethod(driver, _Enter_Work_Email);
            action.Type(_Enter_Work_Email, Text);
        }
        public string UseYourBussinessAccountText()
        {
            action.HighLighterMethod(driver, _userYourBussiness_account);
            return  _userYourBussiness_account.Text;
        }
        public void GoogleAccount()
        {
            action.HighLighterMethod(driver, _google_Id_signIn);
            //  action.Click(driver, _google_Id_signIn);
            action.IsElementEnabled(driver, _google_Id_signIn);
        }
        public void Term_Condition()
        {
            action.HighLighterMethod(driver, _TermAgreeement);
            action.IsElementEnabled(driver, _TermAgreeement);
        }
        public void Privacy()
        {
            action.HighLighterMethod(driver, _Privacy);
            action.IsElementEnabled(driver, _Privacy);
        }
        public void PersonalAccount()
        {
            action.HighLighterMethod(driver, _Personal_account);
            action.Click(driver, _Personal_account);
        }
        public string Email_MobileNumberText()
        {
            action.HighLighterMethod(driver, _Email_MobileNumber_Text);
            return _Email_MobileNumber_Text.Text;
        }
        public void EnterEmail_MobileNumber(string text)
        {
            action.HighLighterMethod(driver, _Email);
            action.Click(driver, _Email);
            action.Type(_Email, text);
        }
        public void back_Button()
        {
            action.HighLighterMethod(driver, _back);
            action.Click(driver, _back);
        }
        public string LoginWithPasswordText()
        {
            action.HighLighterMethod(driver, _LoginWithPasswordText);
            return _LoginWithPasswordText.Text;
        }
        public string Passwordtext()
        {
            action.HighLighterMethod(driver, _PasswordText);
            return _PasswordText.Text;
        }
        public void PasswordEnter(string text)
        {
            action.HighLighterMethod(driver, _Password);
            action.Type(_Password, text);
        }
        public void RestPassword()
        {
            action.HighLighterMethod(driver, _ResetPassword);
            action.IsElementDisplayed(driver, _ResetPassword);
        }
           
        public string ErrorMessagePleaseEnterPass()
        {
            action.HighLighterMethod(driver,_Error_PleaseEnterPassword);
            return _Error_PleaseEnterPassword.Text;
        }
        
        public void LoginPageButton()
        {
            action.HighLighterMethod(driver, _LoginPageButton);
            action.Click(driver, _LoginPageButton);
        }

        public bool Email_ContinueButton()
        {
            action.HighLighterMethod(driver, _Email_Continue);
            if (_Email_Continue.Enabled == true)
            {
                action.Click(driver, _Email_Continue);
            }
            else
            {
                Console.WriteLine("Continue button is Disabled");

            }
            return false;

        }



    }
}
