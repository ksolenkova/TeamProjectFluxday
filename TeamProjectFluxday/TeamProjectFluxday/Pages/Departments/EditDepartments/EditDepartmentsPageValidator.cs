using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class EditDepartmentsPageValidator : BasePageValidator<EditDepartmentsPageMap>
    {
        internal void CancelAndSaveButtonsAreEnabled()
        {
            Assert.IsTrue(Map.Cancel.Enabled);
            Assert.IsTrue(Map.Save.Enabled);
        }
    }
}
