using System.Threading;
using TeamProjectFluxday.Core;
using TeamProjectFluxday.Data;

namespace TeamProjectFluxday.Pages.MyTasks.AddNewTask
{
    public class AddNewTaskPage : BasePage<AddNewTaskPageMap, AddNewTaskPageValidator>
    {
        public AddNewTaskPage(string url = "https://app.fluxday.io/tasks/new#pane3") : base(url)
        {
        }

        internal void CreateNewTask()
        {
            var newTask = TestData.Task;

            Map.TitleInput.SendKeys(newTask.Title);

            Map.DescriptionInput.SendKeys(newTask.Description);

            Map.CreateTaskButton.Click();
        }
    }
}
