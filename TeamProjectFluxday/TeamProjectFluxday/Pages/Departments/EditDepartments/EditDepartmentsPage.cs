using System;
using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class EditDepartmentsPage : BasePage<EditDepartmentsPageMap, EditDepartmentsPageValidator>
    {
       private  DepartmentsPage departmentsPage;

        public EditDepartmentsPage() : base()
        {
            DepartmentsPage = new DepartmentsPage();
        }


        public DepartmentsPage DepartmentsPage
        {
            get
            {
                return departmentsPage;
            }
            private set
            {
                departmentsPage = value;
            }
        }

        internal DepartmentsPage EditTitle(string text)
        {
            var titleField = Map.TitleField;
            titleField.Click();
            titleField.Clear();
            titleField.SendKeys(text);

            Map.Save.Click();

            return new DepartmentsPage();
        }
    }
}
