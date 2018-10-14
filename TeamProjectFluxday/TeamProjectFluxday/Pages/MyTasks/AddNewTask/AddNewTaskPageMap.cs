using OpenQA.Selenium;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages.MyTasks.AddNewTask
{
    public class AddNewTaskPageMap : BasePageMap
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

        public IWebElement AddNewTaskPageTitle
        {
            get
            {
                return GetElement(By.XPath(@"//*[@id='new_task']/div[3]/div[1]"));
            }
        }
    }
}
