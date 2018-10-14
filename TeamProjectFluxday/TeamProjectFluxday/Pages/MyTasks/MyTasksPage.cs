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

        internal void DeleteNewTask()
        {
            Map.NewTask.Click();
            Thread.Sleep(1000);
            Map.SettingsButton.Click();
            Thread.Sleep(1000);
            Map.DeleteOption.Click();
        }

        internal void EditTask()
        {
            Map.NewTask.Click();
            Thread.Sleep(1000);
            Map.SettingsButton.Click();
            Thread.Sleep(1000);
            Map.EditOption.Click();

            var titleInput = Map.TitleInput;
            titleInput.Click();
            titleInput.Clear();
            titleInput.SendKeys("Edited Title");

            var descriptionInput = Map.DescriptionInput;
            descriptionInput.Click();
            descriptionInput.Clear();
            descriptionInput.SendKeys("Edited Description");

            Map.UpdateTask.Click();
        }

        internal void CompletedButton()
        {
            Thread.Sleep(1000);
            Map.CompletedTasksButton.Click();
        }

        internal void AddSubtask()
        {
            Map.NewTask.Click();
            Thread.Sleep(1000);
            Map.AddSubtaskButton.Click();

            var subtask = TestData.Subtask;

            Map.TitleInput.SendKeys(subtask.Title);

            Map.DescriptionInput.SendKeys(subtask.Description);

            Map.CreateSubtaskButton.Click();
        }

        internal void DeleteTasks()
        {
            do
            {
                DeleteNewTask();               
            } while (!Map.TasksNotExist);
        }
    }
}
