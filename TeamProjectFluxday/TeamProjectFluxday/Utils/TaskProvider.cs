using TeamProjectFluxday.Pages;

namespace TeamProjectFluxday.Utils
{
    public static class TaskProvider
    {
        public static void CreateTask(DashboardPage dashboardPage)
        {
            var addNewTaskPage = dashboardPage.NavigationPanel.NavigateToAddNewTaskPage();

            addNewTaskPage.CreateNewTask();
        }
    }
}
