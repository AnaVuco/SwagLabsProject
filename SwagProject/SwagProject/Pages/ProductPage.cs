using OpenQA.Selenium;
using SwagProject.Driver;

namespace SwagProject.Pages
{
    public class ProductPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement AddBackPac => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement AddT_Shirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Cart => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));

    }
    
}
