using OpenQA.Selenium;
using SeleniumWebDriver.Core;

namespace TeamProjectFluxday.Pages.MyTasksPage
{
    public class MyTasksPageMap : BasePageMap
    {


        public IWebElement NewTaskButton
        {
            get
            {
                return GetElement(By.XPath(@"//a[contains(text(),'+Task')]"));
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

        public IWebElement CreateTaskButton
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='new_task']/div[3]/div[2]/input"));
            }
        }

        public IWebElement TaskTitle
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='paginator']/a/div/div[1]"));
            }
        }

    }
}
