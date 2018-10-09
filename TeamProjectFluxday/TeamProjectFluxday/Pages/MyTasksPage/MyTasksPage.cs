using SeleniumWebDriver.Core;

namespace TeamProjectFluxday.Pages.MyTasksPage
{
    public class MyTasksPage : BasePage<MyTasksPageMap>
    {
        public MyTasksPage(string url = "https://app.fluxday.io/tasks#pane2") : base(url)
        {
        }

        internal void PressNewTaskButton()
        {
            Map.NewTaskButton.Click();
        }

        internal void TypeTitle(string title)
        {
            var titleInput = Map.TitleInput;
            titleInput.Click();
            titleInput.Clear();
            titleInput.SendKeys(title);
        }

        internal void TypeDescription(string description)
        {
            var descriptionInput = Map.DescriptionInput;
            descriptionInput.Click();
            descriptionInput.Clear();
            descriptionInput.SendKeys(description);
        }

        internal void PressCreateTaskButton()
        {
            Map.CreateTaskButton.Click();
        }

        internal string ReadTaskTitleText()
        {
            return Map.TaskTitle.Text;
        }

    }
}
