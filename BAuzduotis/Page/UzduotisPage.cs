using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace autotests.Page
{
    public class UzduotisPage : BasePage
    {
        private const string AddressUrl = "http://automationpractice.com/index.php";


        private IWebElement searchField => Driver.FindElement(By.Id("search_query_top"));
        private IWebElement searchIcon => Driver.FindElement(By.CssSelector("#searchbox > button"));
        private IWebElement productAfterSearch => Driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(1) > div > div.right-block > h5 > a"));
        private IWebElement goToProduct => Driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(1) > div > div.left-block > div > a.product_img_link > img"));
        private IWebElement addToCartButton => Driver.FindElement(By.Id("add_to_cart"));

        private IWebElement productInCart => Driver.FindElement(By.CssSelector("#cart_summary > tbody > tr:first-child > td.cart_description > p > a"));
        private IWebElement proceedToCheckoutButton => Driver.FindElement(By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a"));
        private IWebElement proceedToCheckoutButtonInSummary => Driver.FindElement(By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium"));
        private IWebElement emailInputField => Driver.FindElement(By.Id("email_create"));
        private IWebElement createAccountButton => Driver.FindElement(By.Id("SubmitCreate"));
        private IWebElement nameInputField => Driver.FindElement(By.Id("customer_firstname"));
        private IWebElement lastnameInputField => Driver.FindElement(By.Id("customer_lastname"));
        private IWebElement passwordInputField => Driver.FindElement(By.Id("passwd"));
        private IWebElement addressInputField => Driver.FindElement(By.CssSelector("#address1"));
        private IWebElement cityInputField => Driver.FindElement(By.Id("city"));
        private SelectElement stateDropdown => new SelectElement(Driver.FindElement(By.Id("id_state")));
        private IWebElement postcodeInputField => Driver.FindElement(By.Id("postcode"));     
        private IWebElement mobilePhoneInputField => Driver.FindElement(By.Id("phone_mobile"));
        private IWebElement registerButton => Driver.FindElement(By.Id("submitAccount"));
        private IWebElement proceedToCheckoutButtonInAddress => Driver.FindElement(By.CssSelector("#center_column > form > p > button"));
        private IWebElement termOfServiceCheckbox => Driver.FindElement(By.Id("cgv"));
        private IWebElement proceedToCheckoutButtonInShipping => Driver.FindElement(By.CssSelector("#form > p > button"));
        private IWebElement payByBankWire => Driver.FindElement(By.CssSelector("#HOOK_PAYMENT > div:nth-child(1) > div > p > a"));
        private IWebElement confirmMyOrderButton => Driver.FindElement(By.CssSelector("#cart_navigation > button"));
        private IWebElement confirmationByBankWire => Driver.FindElement(By.CssSelector("#center_column > div > p > strong"));
        private IWebElement signOutButton => Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(2) > a"));
        private IWebElement payByCheck => Driver.FindElement(By.CssSelector("#HOOK_PAYMENT > div:nth-child(2) > div > p > a"));
        private IWebElement confirmationByCheck => Driver.FindElement(By.CssSelector("#center_column > p.alert.alert-success"));
        public UzduotisPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != AddressUrl)
            {
                Driver.Url = AddressUrl;
            }
        }

        public void SearchByText(string text)
        {
            searchField.Clear();
            searchField.SendKeys(text);
            searchIcon.Click();
        }


        public void ClickOnSearchIcon()
        {
            searchIcon.Click();
        }


        public void CheckIfCorrectProductAfterSearch(string text)
        {
            Assert.IsTrue(productAfterSearch.Text.Contains(text), "There is no word from search field");
        }

        public void ClickToGoToProductInside()
        {
            goToProduct.Click();
        }


        public void AddToCartButtonClick()
        {
            addToCartButton.Click();
        }


        public void CheckIfProductVisibleInCart(string text)
        {
            Assert.IsTrue(productInCart.Text.Contains(text), $"There is something wrong, {productInCart.Text}");
        }


        public void ProceedToCheckoutButtonClick()
        {
            proceedToCheckoutButton.Click();
        }


        public void ProceedToCheckoutButtonInSummaryClick()
        {
            proceedToCheckoutButtonInSummary.Click();
        }

        public void FillRequiredInformation(string email, string name, string lastname, string password, string address, string city, string state, string postcode, string mobilePhone)
        {
            emailInputField.SendKeys(email);
            createAccountButton.Click();
            nameInputField.SendKeys(name);
            lastnameInputField.SendKeys(lastname);
            passwordInputField.SendKeys(password);
            addressInputField.SendKeys(address);
            cityInputField.SendKeys(city);
            stateDropdown.SelectByText(state);
            postcodeInputField.SendKeys(postcode);
            mobilePhoneInputField.SendKeys(mobilePhone);
            registerButton.Click();
        }

        public void ProceedToCheckoutButtonInAddressClick()
        {
            proceedToCheckoutButtonInAddress.Click();
        }


        public void TermOfServiceCheckbox()
        {
            if (!termOfServiceCheckbox.Selected)
            {
                termOfServiceCheckbox.Click();
            }
        }


        public void ProceedToCheckoutButtonInShippingClick()
        {
            proceedToCheckoutButtonInShipping.Click();
        }


        public void PayByBankWireClick()
        {
            payByBankWire.Click();
        }


        public void ConfirmMyOrderButtonClick()
        {
            confirmMyOrderButton.Click();
        }


        public void CheckIfOrderByBankWireIsConfirmed(string confirmationMessage)
        {
            Assert.IsTrue(confirmationByBankWire.Text.Contains(confirmationMessage), "There is no confirmation message");
        }

        public void SignOutButtonClick()
        {
            signOutButton.Click();
        }


        public void PayByCheckClick()
        {
            payByCheck.Click();
        }


        public void CheckIfOrderByCheckIsConfirmed(string confirmationMessage)
        {
            Assert.IsTrue(confirmationByCheck.Text.Contains(confirmationMessage), "There is no confirmation message");
        }

    }
}
