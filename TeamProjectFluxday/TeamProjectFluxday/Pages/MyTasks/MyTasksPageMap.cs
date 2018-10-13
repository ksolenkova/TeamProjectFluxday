using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class MyTasksPageMap : BasePageMap
    {
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

        public IWebElement CreateTaskButton
        {
            get
            {
                return GetElement(By.CssSelector(".button"));
            }
        }

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
                return GetElement(By.XPath(@"//*[@id='pane3']/div[2]/div/div[1]/div[1]/div/a[2]"));
            }
        }

        public IWebElement DeleteOption
        {
            get
            {
                return GetElement(By.XPath(@"//a[contains(text(),'Delete')]"));
            }
        }
    }
}
