using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    [TestFixture]
    public class Class1
    {
        IWebDriver Driver;
        // IWebDriver wait;

        [SetUp]
        public void setiranje()
        {

            Driver = new ChromeDriver();


        }
        [Test]
        public void elektronsko()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Driver.Navigate().GoToUrl("https://testibanking.stbbt.mk/#/login");

            Driver.FindElement(By.ClassName("fa-user-group")).Click();
            IWebElement zaboravena = Driver.FindElement(By.CssSelector(".btn.btn-primary.btn-block.btnForgot"));
            zaboravena.Click();

            IWebElement emaill = Driver.FindElement(By.CssSelector(".form-control.ng-untouched.ng-pristine.ng-invalid"));
            emaill.SendKeys("ndimoski823");

            IWebElement potvdi = Driver.FindElement(By.CssSelector(".btn.btn-flat.position.fstepBtn.btnForgotPw"));
            potvdi.Click();

            IWebElement polePotvrdiLozinka = Driver.FindElement(By.CssSelector(".form-group.col-sm-7.text-left.align-items-center.d-flex"));


            Assert.AreEqual("Внесете го безбедносниот кодот:", polePotvrdiLozinka.Text);





        }
        [TearDown]
        public void Terdown()
        {
            Driver.Dispose();

        }
        [Test]
        public void elektronsko22()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Driver.Navigate().GoToUrl("https://testibanking.stbbt.mk/#/login");

            Driver.FindElement(By.CssSelector(".forBank.d-flex.justify-content-end")).Click();
            Assert.IsTrue(Driver.Url.Contains("https://www.stbbt.mk/"));


        }
        [Test]
        public void elektronskoNajavaFL()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Driver.Navigate().GoToUrl("https://testibanking.stbbt.mk/#/login");

            Driver.FindElement(By.CssSelector(".fa-solid.fa-user-group")).Click();
            IWebElement KIme = Driver.FindElement(By.CssSelector("input[placeholder='Корисничко име / email']"));
            KIme.Clear();
            KIme.SendKeys("nkrstevska810");

            IWebElement passs = Driver.FindElement(By.CssSelector("input[placeholder='Лозинка']"));
            passs.Clear();
            passs.SendKeys("zxZX123!!");

            Driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            IWebElement avtentikacija = Driver.FindElement(By.CssSelector(".col-sm-12.d-flex.justify-content-center.align-items-center.mb-4.mt-3"));

            Assert.IsTrue(avtentikacija.Text.Contains("АВТЕНТИКАЦИЈА"));
        }
        [Test]
        public void elektronskoJuTub()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Driver.Navigate().GoToUrl("https://testibanking.stbbt.mk/#/login");

            Driver.FindElement(By.CssSelector("img[src='assets/img/youtube-logo(4).png']")).Click();
            Assert.IsTrue(Driver.Url.Contains("https://www.youtube.com/channel/UCpvtyYwcrlIMR35V3oRk3hA"));

        }
        [Test]
        public void YutubeProba()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Driver.Navigate().GoToUrl("https://www.youtube.com/");

            IWebElement searchBox = Driver.FindElement(By.CssSelector("input[id='search']"));

            searchBox.SendKeys("halid beslic");
            searchBox.SendKeys(Keys.Enter);
            // Console.ReadLine();

            //wait.Until()
            IWebElement tekstHalid = Driver.FindElement(By.CssSelector(".yt-simple-endpoint.style-scope.ytd-watch-card-rich-header-renderer"));

            Assert.IsTrue(tekstHalid.Text.Contains("Halid"));





        }
        [Test]
        public void YutubeProbaPesmaPustena()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Driver.Navigate().GoToUrl("https://www.youtube.com/");

            IWebElement searchBox = Driver.FindElement(By.CssSelector("input[id='search']"));

            searchBox.SendKeys("halid beslic");
            searchBox.SendKeys(Keys.Enter);
            IWebElement pesma = Driver.FindElement(By.CssSelector(".yt-simple-endpoint.style-scope.ytd-video-renderer"));
            pesma.Click();

            IWebElement dokazZaRomanija = Driver.FindElement(By.CssSelector(".style-scope.ytd-video-primary-info-renderer"));
            Assert.IsTrue(Driver.Url.Contains("HsqtnQjeDTE"));
        }
    }
}
