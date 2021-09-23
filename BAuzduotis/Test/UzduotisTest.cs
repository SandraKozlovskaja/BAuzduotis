using NUnit.Framework;

namespace autotests.Test
{
    public class UzduotisTest : BaseTest
    {
        //First payment option (bank wire)
        [Test]
        public static void TestProductPurchaseBankWire()
        {
            uzduotisPage.NavigateToPage();
            uzduotisPage.SearchByText("dress");
            uzduotisPage.ClickOnSearchIcon();
            uzduotisPage.CheckIfCorrectProductAfterSearch("Dress");
            uzduotisPage.ClickToGoToProductInside();
            uzduotisPage.AddToCartButtonClick();
            
            uzduotisPage.ProceedToCheckoutButtonClick();
            uzduotisPage.CheckIfProductVisibleInCart("Dress");
            uzduotisPage.ProceedToCheckoutButtonInSummaryClick();
            uzduotisPage.FillRequiredInformation("bankwireemail@bca.lt", "Vardenis", "Pavardenis", "asdfghjklkj", "Gedimino g. 29", "Vilnius", "Alabama", "12345", "23456789");
            uzduotisPage.ProceedToCheckoutButtonInAddressClick();
            uzduotisPage.TermOfServiceCheckbox();
            uzduotisPage.ProceedToCheckoutButtonInShippingClick();
            uzduotisPage.PayByBankWireClick();
            uzduotisPage.ConfirmMyOrderButtonClick();
            uzduotisPage.CheckIfOrderByBankWireIsConfirmed("Your order on My Store is complete");
            uzduotisPage.SignOutButtonClick();
        }

        //Second payment option (check)
        [Test]
        public static void TestProductPurchaseCheck()
        {
            uzduotisPage.NavigateToPage();
            uzduotisPage.SearchByText("dress");
            uzduotisPage.ClickOnSearchIcon();
            uzduotisPage.CheckIfCorrectProductAfterSearch("Dress");
            uzduotisPage.ClickToGoToProductInside();
            uzduotisPage.AddToCartButtonClick();
            uzduotisPage.ProceedToCheckoutButtonClick();
            uzduotisPage.CheckIfProductVisibleInCart("Dress");
            uzduotisPage.ProceedToCheckoutButtonInSummaryClick();
            uzduotisPage.FillRequiredInformation("checkemail@bca.lt", "Vardenis", "Pavardenis", "asdfghjklkj", "Gedimino g. 29", "Vilnius", "Alabama", "12345", "23456789");
            uzduotisPage.ProceedToCheckoutButtonInAddressClick();
            uzduotisPage.TermOfServiceCheckbox();
            uzduotisPage.ProceedToCheckoutButtonInShippingClick();
            uzduotisPage.PayByCheckClick();
            uzduotisPage.ConfirmMyOrderButtonClick();
            uzduotisPage.CheckIfOrderByCheckIsConfirmed("Your order on My Store is complete");
        }
    }
}
