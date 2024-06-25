using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;

namespace CSharpSelenium
{
    [TestFixture]
    public class FirtsTestAppium
    {
        private AndroidDriver driver;

        [SetUp]
        public void Setup()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554"); // Change to your device name
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "path/to/your/app.apk"); // Change to your app path

            driver = new AndroidDriver(new Uri("http://localhost:4723/wd/hub"), appiumOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [Test]
        public void setUP()
        {

            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("appium:automationName", "uiautomator2");
            appiumOptions.AddAdditionalCapability("appium:deviceName", "Pixel 4");
            appiumOptions.AddAdditionalCapability("appium:platformVersion", "11.0");
            appiumOptions.AddAdditionalCapability("appium:app", "C:\\Users\\aarti\\Downloads\\english-demo.apk");
            appiumOptions.AddAdditionalCapability("appium:fullReset", true);
            appiumOptions.AddAdditionalCapability("appium:automationName", "uiautomator2");
            Driver = new AndroidDriver(new Uri("http://127.0.0.1:4723/"), appiumOptions);
        }

    }
}
