﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;
using TeamProjectFluxday.Pages;
using TeamProjectFluxday.Utils;

namespace TeamProjectFluxday.Tests
{
    [TestClass]
    public class UsersPageTests : BaseTest
    {
        DashboardPage dashboardPage;

        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowser();
            dashboardPage = LoginProvider.Login(TestData.AdminUser);
        }

        [TestCategory("UsersPageTests")]
        [TestMethod]

        public void Test001UsersPageValidation()
        {
            var usersPage = dashboardPage.NavigationPanel.NavigateToUsersPage();

            usersPage.Validate().IsOnUsersPage();
        }
    }
}
