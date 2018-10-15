using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class CreateDepartmentsValidator : BasePageValidator<CreateDepartmentsPageMap>
    {
        internal void CreateDepartmentForm()
        {
            Assert.IsTrue(Map.TitleField.Displayed);
            Assert.IsTrue(Map.CodeDepartment.Displayed);
            Assert.IsTrue(Map.Url.Displayed);
            Assert.IsTrue(Map.Description.Displayed);
        }
    }
}
