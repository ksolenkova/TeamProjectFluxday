using System.Threading;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;

namespace TeamProjectFluxday.Pages
{
    public class MyTasksPage : BasePage<MyTasksPageMap, MyTasksPageValidator>
    {
        public MyTasksPage(string url = "https://app.fluxday.io/tasks#pane2") : base(url)
        {
        }

        internal void CreateNewTask()
        {
            var newTask = TestData.Task;

            Map.TitleInput.SendKeys(newTask.Title);

            Map.DescriptionInput.SendKeys(newTask.Description);

            Map.CreateTaskButton.Click();
        }

        internal void DeleteNewTask()
        {
            Map.NewTask.Click();
            Thread.Sleep(1000);
            Map.SettingsButton.Click();
            Thread.Sleep(1000);
            Map.DeleteOption.Click();
        }
    }
}
