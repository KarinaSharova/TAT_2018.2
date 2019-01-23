using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace dev9
{
    // logs in to VKontakte, finds and displays an unread message.
    class Program
    {
        // entry point
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver();

            // waits 10 seconds until the page https://vk.com/login opens
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://vk.com/login");

            // enters the login and password, presses the enter button
            IWebElement login = driver.FindElement(By.Id("email"));
            IWebElement password = driver.FindElement(By.Id("pass"));
            IWebElement loginButton = driver.FindElement(By.Id("login_button"));
            login.SendKeys("login");
            password.SendKeys("password");
            loginButton.Click();

            // press the button "messages"
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement messagesButton = driver.FindElement(By.Id("l_msg"));
            messagesButton.Click();

            // press the button "unread messages"
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement unreadMessagesButton = driver.FindElement(By.Id("ui_rmenu_unread"));
            messagesButton.Click();

            // finds and displays an unread message
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement unreadMessageElement = driver.FindElement(By.XPath("//*[@id=\"ui_rmenu_unread\"]/span/span"));
            string unreadMessage = unreadMessageElement.Text;
            Console.Write(unreadMessage);
        }
    }
}
