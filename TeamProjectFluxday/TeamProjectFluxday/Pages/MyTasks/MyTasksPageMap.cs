﻿using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class MyTasksPageMap : BasePageMap
    {
        public IWebElement TaskTitle
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='paginator']/a/div/div[1]"));
            }
        }

        public IWebElement NewTask
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='paginator']/a/div"));
            }
        }

        public IWebElement SettingsButton
        {
            get
            {
                return GetElement(By.CssSelector(@"div.icon.settings-link"));
            }
        }

        public IWebElement DeleteOption
        {
            get
            {
                return GetElement(By.XPath(@"//a[contains(text(),'Delete')]"));
            }
        }

        public IWebElement MyTasksPageTitle
        {
            get
            {
                return GetElement(By.CssSelector(@"div.title"));
            }
        }

        public IWebElement EditOption
        {
            get
            {
                return GetElement(By.XPath(@"//a[contains(text(),'Edit')]"));
            }
        }

        public IWebElement TitleInput
        {
            get
            {
                return GetElement(By.CssSelector("#task_name"));
            }
        }

        public IWebElement DescriptionInput
        {
            get
            {
                return GetElement(By.CssSelector("#task_description"));
            }
        }

        public IWebElement UpdateTask
        {
            get
            {
                return GetElement(By.CssSelector(".button"));
            }
        }

        public IWebElement CompletedTaskTitle
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='paginator']/a/div/div[1]"));
            }
        }

        public IWebElement CompletedTasksButton
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='pane2']/div[1]/dl/dd[2]"));
            }
        }

        public IWebElement AddSubtaskButton
        {
            get
            {
                return GetElement(By.CssSelector(".dashed_link"));
            }
        }

        public IWebElement CreateSubtaskButton
        {
            get
            {
                return GetElement(By.CssSelector(".button"));
            }
        }

        public IWebElement SubtaskTitle
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='paginator']/a/div/div[1]"));
            }
        }

        public bool TasksNotExist
        {
            get
            {
                return ElementIsNotPresent(By.XPath(@"//*[@id='paginator']/a/div"));
            }
        }
    }
}
