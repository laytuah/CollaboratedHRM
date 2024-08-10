using OpenQA.Selenium;

namespace CollaboratedHRM.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }


        protected IWebElement ConfirmationBarChart => Driver.FindElement(By.XPath("(//canvas)[1]"));
        protected IWebElement ConfirmationPieChart => Driver.FindElement(By.XPath("(//div[@class='oxd-pie-chart']//canvas)[1]"));

        By PimClickButton = By.XPath("//div[2]/ul/li[2]/a/span");



        public bool IsBarchartDisplay()
        {
            return ConfirmationBarChart.Displayed;
        }

        public bool IsConfirmationPieChartDisplayed()
        {
            return ConfirmationPieChart.Displayed;
        }

        public PimPage clickPimButton()
        {
            Driver.FindElement(PimClickButton).Click();
            return new PimPage(Driver);
        }
    }
}
