using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CSharpSelenium
{
    public class Tests
    { 
    private IWebDriver _driver; 


        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.google.co.in/");
        }

        [Test]
        public void Test1()
        {
            IWebElement webElement = _driver.FindElement(By.Id("APjFqb"));
            webElement.SendKeys("Visual Studio");
            webElement.SendKeys(Keys.Return);
        }

        [Test]
        public void DropDown()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/select-dropdown-menu/");
            IWebElement webElement = driver.FindElement(By.XPath("(//select)[1]"));
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue("IND");
            selectElement.SelectByIndex(5);
            selectElement.SelectByText("Israel");

            //get selected option
            IWebElement selectedOption = selectElement.SelectedOption;
            Console.WriteLine(selectedOption.Text);

            IList<IWebElement> options = driver.FindElements(By.CssSelector("select option"));
            foreach (IWebElement element in options)
            {
                Console.WriteLine(element.Text);
            }
          
        }

        [TearDown]
        public void tearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}