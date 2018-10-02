﻿using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.LoginPage
{
    public class LoginPageMap : BasePageMap
    {
        public IWebElement EmailInput
        {
            get
            {
                return GetElement(By.CssSelector("#user_email"));
            }
        }

        public IWebElement PasswordInput
        {
            get
            {
                return GetElement(By.CssSelector("#user_password"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return GetElement(By.CssSelector(".btn-login"));
            }
        }
    }
}
