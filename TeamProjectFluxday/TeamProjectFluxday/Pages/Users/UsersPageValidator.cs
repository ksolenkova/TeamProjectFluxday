using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public  class UsersPageValidator : BasePageValidator<UsersPageMap>
    {
        public void IsOnUsersPage()
        {
            Thread.Sleep(2000);
            var expectedResult = "Users";
            Assert.AreEqual(expectedResult, Map.UsersTitle.Text);
        }

        internal void NewEmployeeIsAdded()
        {
            Assert.IsTrue(Map.NewUser.Displayed, "New user is not added!");
        }

        internal void AddUserLinkIsAvailabe()
        {
            var expectedResult = "Add user";
            Assert.IsTrue(Map.AddUser.Displayed, "Add user link is not displayed!");
            Assert.IsTrue(Map.AddUser.Enabled, "Add user link is not enabled!");
            Assert.AreEqual(expectedResult, Map.AddUser.Text);
        }

        internal void DefaultUsersListCount()
        {
            Assert.AreEqual(4, Map.ListOfUsers.Count);
        }

        internal void NewEmployeeIsNotInTheList()
        {
            Assert.IsTrue(Map.NewEmployeeNotVisible, "New employee is in the list!");
        }

        internal void TeamLeadIsInUsersList()
        {
            Assert.AreEqual(Map.TeamLeadUser.Text, "Team Lead");
        }
    }
}
