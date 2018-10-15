using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class TeamDetailsPageValidator : BasePageValidator<TeamDetailsPageMap>
    {
        public void DevOpsTitle()
        {
            var expectedResult = "DevOps";
            Assert.AreEqual(expectedResult, Map.TeamTitle.Text);
        }

        public void UzityTeamMembersCount()
        {
            var expectedResult = Int32.Parse(Map.UzityTeamMembersCount.Text);
            Assert.AreEqual(3, expectedResult);
        }

        public void SupportTeamAddMembersButton()
        {
            var expectedResult = Map.AddMembersButton.Displayed
                && Map.AddMembersButton.Enabled;
            Assert.IsTrue(expectedResult);
        }

        public void EditedSupportTitle(string editedTitle)
        {
            Assert.AreEqual(editedTitle, Map.TeamTitle.Text);
        }
    }
}
