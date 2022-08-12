using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    [TestFixture]
    public class Testiranje
    {
        IWebDriver Driver;
        [SetUp]
        public void TestiranjeSetup()
        {
            Driver = new ChromeDriver();
            // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
        [Category("Testovi")]
        [Test]
        public void Login()

        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://safeentries.com/#/");
            IWebElement username = Driver.FindElement(By.Id("mat-input-0"));
            username.Clear();
            username.SendKeys("dejanovski_a@yahoo.com");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("mat-input-1")));
            IWebElement password = Driver.FindElement(By.Id("mat-input-1"));

            password.Clear();
            password.SendKeys("aA123456789");

            IWebElement loginButton = Driver.FindElement(By.CssSelector("button[type='button']"));
            loginButton.Click();

            IWebElement titleName = Driver.FindElement(By.Id("textLogo"));
            Assert.AreEqual("Safe Entries", titleName.Text);

            // IWebElement company = Driver.FindElement(By.CssSelector("a[href='#/main/clients']"));
            //  company.Click();

            // IWebElement sliderce = Driver.FindElement(By.Id("mat-slide-toggle-1"));
            // sliderce.Click();
            // Driver.Dispose();
        }
        [TearDown]
        public void TearDown1()
        {
            //IWebDriver Driver = new ChromeDriver();
            //Driver.Quit();
            Driver.Dispose();
        }
        [Test]
        public void TestiranjeIPracanjeNaSertifikat()
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://safeentries.com/#/");
            IWebElement username = Driver.FindElement(By.Id("mat-input-0"));
            username.Clear();
            username.SendKeys("aleksandar.dejanovski@interway.com.mk");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("mat-input-1")));
            IWebElement password = Driver.FindElement(By.Id("mat-input-1"));

            password.Clear();
            password.SendKeys("aA123456789");

            IWebElement loginButton = Driver.FindElement(By.CssSelector("button[type='button']"));
            loginButton.Click();

            IWebElement titleName = Driver.FindElement(By.Id("textLogo"));
            Assert.AreEqual("Safe Entries", titleName.Text);

            IWebElement Testingrr = Driver.FindElement(By.CssSelector("a[href='#/main/testing']"));
            Testingrr.Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("searchInput"))).Click();
            //IWebElement SrcBar = Driver.FindElement(By.Id("searchInput"));


            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("mat-input-2")));
            IWebElement vnes = Driver.FindElement(By.Id("mat-input-2"));
            vnes.SendKeys("fil");


            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("input[aria-describedby='search-text']")));
            IWebElement vnes2 = Driver.FindElement(By.CssSelector("input[aria-describedby='search-text']"));
            vnes2.SendKeys("l");


            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("mat-option-263"))).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("mat-select[role='combobox']")));
            IWebElement testType = Driver.FindElement(By.CssSelector("mat-select[role='combobox']"));
            testType.Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mat-option-8")));
            IWebElement izbor1 = Driver.FindElement(By.Id("mat-option-8"));
            izbor1.Click();



            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("mat-select-value-3")));
            IWebElement testResult = Driver.FindElement(By.Id("mat-select-value-3"));
            testResult.Click();
            testResult.SendKeys(Keys.Down + Keys.Enter);
            testResult.Click();

            //  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("mat-option-558")));
            // IWebElement testResult2 = Driver.FindElement(By.Id("mat-option-558"));
            // testResult2.Click();

            IWebElement cekboks = Driver.FindElement(By.Id("checkB"));
            cekboks.Click();

            IWebElement certifikatGenerate = Driver.FindElement(By.Id("generateCertificate"));
            certifikatGenerate.Click();

            IWebElement naslovZaDokaz = Driver.FindElement(By.CssSelector("div[class='mat-card-header-text']"));
            Assert.AreEqual("COVID-19 Test Record Card", naslovZaDokaz.Text);








            Driver.Dispose();




        }
        [Test]
        public void najavaItestIDokazDekaENajaveno()
        {

            IWebDriver Driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("http://192.168.1.160:8016/iBank/#/");
            //wait.(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("input[placeholder='Корисничко име']")));
            IWebElement KIme = Driver.FindElement(By.CssSelector("input[placeholder='Корисничко име']"));
            KIme.Clear();
            KIme.SendKeys("aa");

            IWebElement Passs = Driver.FindElement(By.CssSelector("input[placeholder='Лозинка']"));
            Passs.Clear();
            Passs.SendKeys("2");

            IWebElement butonn = Driver.FindElement(By.ClassName("btnNajava"));
            butonn.Click();


            IWebElement dokazDekaENajaveno = Driver.FindElement(By.ClassName("card-inner-container"));
            Assert.AreEqual("Прилив од странство", dokazDekaENajaveno.Text);
            Driver.Dispose();

        }
        [Test]
        public void Verifajer()
        {

            IWebDriver Driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://safeentries.com/#/");

            IWebElement usernameVerifajer = Driver.FindElement(By.Id("mat-input-0"));
            usernameVerifajer.SendKeys("aleksandar.dejanovski@interway.com.mk");

            IWebElement passVerifajer = Driver.FindElement(By.Id("mat-input-1"));
            passVerifajer.SendKeys("aA123456789");

            IWebElement loginVerifjer = Driver.FindElement(By.CssSelector("button[type='button']"));
            loginVerifjer.Click();

            IWebElement tekstLogoZaDokaz = Driver.FindElement(By.Id("textLogo"));
            Assert.AreEqual("Safe Entries", tekstLogoZaDokaz.Text);
            Driver.Dispose();


        }
        [Test]
        public void AdCekpoint()
        {

            IWebDriver Driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://safeentries.com/#/");

            IWebElement usernameVerifajer = Driver.FindElement(By.Id("mat-input-0"));
            usernameVerifajer.SendKeys("aleksandar.dejanovski@interway.com.mk");

            IWebElement passVerifajer = Driver.FindElement(By.Id("mat-input-1"));
            passVerifajer.SendKeys("aA123456789");

            IWebElement loginVerifjer = Driver.FindElement(By.CssSelector("button[type='button']"));
            loginVerifjer.Click();

            IWebElement cekpoints = Driver.FindElement(By.CssSelector("a[href='#/main/checkpoints']"));
            cekpoints.Click();

            IWebElement novCekpoint = Driver.FindElement(By.Id("addNew"));
            novCekpoint.Click();

            IWebElement conditionName = Driver.FindElement(By.CssSelector("input[data-placeholder='Condtition name']"));
            conditionName.Clear();
            conditionName.SendKeys("Barcelona");

            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("mat-datepicker-toggle[data-mat-calendar=mat-datepicker-4]")));
            //IWebElement calendar = Driver.FindElement(By.CssSelector("mat-datepicker-toggle[data-mat-calendar=mat-datepicker-4]"));
            //calendar.Click();

            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("td[aria-label='5/22/2022']"))).Click();
            //IWebElement datumizbor = Driver.FindElement(By.CssSelector("td[aria-label='5/22/2022']"));
            //datumizbor.Click();

            IWebElement nekst = Driver.FindElement(By.CssSelector("button[class='mat-focus-indicator']"));
            nekst.Click();

            Actions action = new Actions(Driver);
            action.SendKeys(Keys.Escape);
            Driver.Dispose();




        }
        [Test]
        public void redmine()
        {
            IWebDriver Driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("http://192.168.1.160:81/redmine/");

            IWebElement signIn = Driver.FindElement(By.ClassName("login"));
            signIn.Click();

            IWebElement ime = Driver.FindElement(By.Id("username"));
            ime.Clear();
            ime.SendKeys("aleksandar.dejanovski");

            IWebElement pasvordd = Driver.FindElement(By.Id("password"));
            pasvordd.Clear();
            pasvordd.SendKeys("alek9dej1");

            IWebElement submitt = Driver.FindElement(By.Id("login-submit"));
            submitt.Click();

            IWebElement projects = Driver.FindElement(By.ClassName("projects"));
            projects.Click();

            IWebElement elekotronsko = Driver.FindElement(By.CssSelector("a[href='/redmine/projects/e-banking-nadogradba']"));
            elekotronsko.Click();

            IWebElement dokazDekaSmeNaElektronsko = Driver.FindElement(By.ClassName("current-project"));
            Assert.AreEqual("E-Banking nadogradba", dokazDekaSmeNaElektronsko.Text);





            Driver.Dispose();




        }
        [Test]
        public void emaulNajava()
        {

            IWebDriver Driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://webmail.t.mk/cp/ps/Main/login/Authenticate?s=1583873471308050834140&v=1583873471308050834140");

            IWebElement prvopole = Driver.FindElement(By.Id("usrField"));
            prvopole.Clear();
            prvopole.SendKeys("aleksandar.dejanovski@interway.com.mk");

            IWebElement vtoroPole = Driver.FindElement(By.Id("password"));
            vtoroPole.Clear();
            vtoroPole.SendKeys("Interway1102");

            IWebElement loginKopce = Driver.FindElement(By.Name("submitName"));
            loginKopce.Click();

            IWebElement dokaznajavanoeIme = Driver.FindElement(By.Id("Status0"));
            Assert.IsTrue(dokaznajavanoeIme.Text.Contains("aleksandar.dejanovski@interway.com.mk"));
        }
        [Test]
        public void redminePracanePoraka()
        {
            IWebDriver Driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("http://192.168.1.160:81/redmine/");

            IWebElement signIn = Driver.FindElement(By.ClassName("login"));
            signIn.Click();

            IWebElement ime = Driver.FindElement(By.Id("username"));
            ime.Clear();
            ime.SendKeys("aleksandar.dejanovski");

            IWebElement pasvordd = Driver.FindElement(By.Id("password"));
            pasvordd.Clear();
            pasvordd.SendKeys("alek9dej1");

            IWebElement submitt = Driver.FindElement(By.Id("login-submit"));
            submitt.Click();

            IWebElement projects = Driver.FindElement(By.ClassName("projects"));
            projects.Click();

            IWebElement elekotronsko = Driver.FindElement(By.CssSelector("a[href='/redmine/projects/e-banking-nadogradba']"));
            elekotronsko.Click();

            IWebElement isues = Driver.FindElement(By.CssSelector("a[href='/redmine/projects/e-banking-nadogradba/issues']"));
            isues.Click();

            IWebElement newisue = Driver.FindElement(By.CssSelector("a[href='/redmine/projects/e-banking-nadogradba/issues/new']"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("new-issue"))).Click();
            //newisue2.Click();

            IWebElement subjectt = Driver.FindElement(By.Id("issue_subject"));
            subjectt.Clear();
            subjectt.SendKeys("Test");

            IWebElement glavantekst = Driver.FindElement(By.Id("issue_description"));
            glavantekst.SendKeys("Ova e samo proba da vidime deka raboti avtomatski test");

            IWebElement submitq = Driver.FindElement(By.Name("commit"));
            submitq.Click();




            //IWebElement dokazDekaSmeNaElektronsko = Driver.FindElement(By.ClassName("current-project"));
            //Assert.AreEqual("E-Banking nadogradba", dokazDekaSmeNaElektronsko.Text);





            Driver.Dispose();

        }
        [Test]
        public void Ebanking()
        {
            IWebDriver Driver = new ChromeDriver();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://testibanking.stbbt.mk/#/login");

            IWebElement fizickiLica = Driver.FindElement(By.ClassName("fa-user-group"));
            fizickiLica.Click();


        }

    }
}


