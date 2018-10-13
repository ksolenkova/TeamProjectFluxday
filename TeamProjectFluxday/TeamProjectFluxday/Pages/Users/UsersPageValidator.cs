using System;
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

        internal void AddUserLinkIsAvailabe()
        {
            var expectedResult = "Add user";
            Assert.IsTrue(Map.AddUser.Displayed, "Add user link not displayed!");
            Assert.IsTrue(Map.AddUser.Enabled, "Add user link is not enabled!");
            Assert.AreEqual(expectedResult, Map.AddUser.Text);
        }

        internal void DefaultUsersListCount()
        {
            Assert.AreEqual(4, Map.ListOfUsers.Count);
        }
    }
}
