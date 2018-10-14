using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public  class UsersPageValidator : BasePageValidator<UsersPageMap>
    {
        public void IsOnUsersPage()
        {
            var expectedResult = "Users";
            Assert.AreEqual(expectedResult, Map.UsersTitle.Text);
        }

        internal void NewEmployeeIsAdded()
        {
            var expectedResult = "TestEmployee";
            Assert.AreEqual(expectedResult, Map.NewUser.Text);
        }
    }
}
