﻿using System.Threading;
using TeamProjectFluxday.Pages.Departments;
using TeamProjectFluxday.Pages.Login;
using TeamProjectFluxday.Pages.Users;

namespace TeamProjectFluxday.Parts
{
    public class NavigationPanel
    {
        public NavigationPanel()
        {
        }

        public NavigationPanelMap Map
        {
            get
            {
                return new NavigationPanelMap();
            }
        }

        internal string ReadUserLinkText()
        {
            return Map.UserLink.Text;
        }

        internal void ClickOnDepartmentsLink()
        {
            Map.DepartmentsLink.Click();
            Thread.Sleep(2000);
        }

        internal void UsersLinkClick()
        {
            Map.UsersLink.Click();
        }

        internal LoginPage Logout()
        {
            Map.LogoutButton.Click();

            return new LoginPage();
        }

        internal void PressNewTaskButton()
        {
            Map.NewTaskButton.Click();
        }

        internal DepartmentsPage NavigateToDepartmentsPage()
        {
            Map.DepartmentsLink.Click();

            return new DepartmentsPage();
        }

        internal UsersPage NavigateToUsersPage()
        {
            Map.UsersLink.Click();

            return new UsersPage();
        }
    }
}
