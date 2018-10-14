using System.Threading;
using TeamProjectFluxday.Core;

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
    }
}
