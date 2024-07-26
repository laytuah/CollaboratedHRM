using OpenQA.Selenium;

namespace CollaboratedHRM.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement ConfirmationBarChart => _driver.FindElement(By.XPath("(//canvas)[1]"));
        private IWebElement ConfirmationPieChart => _driver.FindElement(By.XPath("(//div[@class='oxd-pie-chart']//canvas)[1]"));

        public bool IsBarchartDisplay()
        {
            return ConfirmationBarChart.Displayed;
        }
        
        public bool IsConfirmationPieChartDisplayed()
        {
            return ConfirmationPieChart.Displayed;
        }
    }
}
