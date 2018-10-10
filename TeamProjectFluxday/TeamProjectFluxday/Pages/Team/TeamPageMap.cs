﻿using OpenQA.Selenium;
using TeamProjectFluxday.Core;
using System.Collections.Generic;

namespace TeamProjectFluxday.Pages.Team
{
    public class TeamPageMap : BasePageMap
    {
        public IWebElement AddTeamButton
        {
            get
            {
                return GetElement(By.CssSelector(".dashed_link"));
            }
        }
        public IWebElement CancelButton
        {
            get
            {
                return GetElement(By.CssSelector(".translation_missing"));
            }
        }
        public IWebElement SaveButton
        {
            get
            {
                return GetElement(By.CssSelector(".button"));
            }
        }
        
        public IReadOnlyCollection<IWebElement> Teams
        {
            get
            {
                return GetElements(By.CssSelector(".pane2-content"));
            }
        }
    }
}
