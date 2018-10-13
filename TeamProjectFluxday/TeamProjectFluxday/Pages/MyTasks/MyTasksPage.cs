using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class MyTasksPage : BasePage<MyTasksPageMap, MyTasksPageValidator>
    {
        public MyTasksPage(string url = "https://app.fluxday.io/tasks#pane2") : base(url)
        {
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

        internal void DeleteNewTask()
        {
            Map.NewTask.Click();
            Map.SettingsButton.Click();
            Thread.Sleep(1000);
            Map.DeleteOption.Click();
        }
    }
}
