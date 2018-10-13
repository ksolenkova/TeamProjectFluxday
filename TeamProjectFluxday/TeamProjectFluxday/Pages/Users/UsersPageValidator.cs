using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public  class UsersPageValidator : BasePageValidator<UsersPageMap>
    {
        public void IsOnUsersPage()
        {
            Assert.IsTrue(Map.AddUser.Displayed, "Users page is not displayed");
        }

        internal void NewEmployeeIsAdded()
        {
            var expectedResult = "TestEmployee";
            Assert.AreEqual(expectedResult, Map.NewUser.Text);
        }
    }
}
