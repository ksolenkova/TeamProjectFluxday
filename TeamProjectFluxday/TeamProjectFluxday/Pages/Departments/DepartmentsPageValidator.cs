﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TeamProjectFluxday.Core;

namespace TeamProjectFluxday.Pages
{
    public class DepartmentsPageValidator : BasePageValidator<DepartmentsPageMap>
    {
        public void IsOnDepartmentsPage()
        {
            var expectedResult = "Departments";
            Thread.Sleep(1000);
            Assert.AreEqual(expectedResult, Map.DepartmentsTitle.Text, "Departments page is not displayed");
        }

        internal void NewDepartmentExists()
        {
            Assert.IsTrue(Map.MainTitleOfDepartment.Displayed, "Newly created department is not displayed!");
        }

        internal void NewDepartmentIsDeleted()
        {
            var expectedResult = "Administration";
            Assert.AreNotSame(expectedResult, Map.MainTitleOfDepartment.Text);
        }

        internal void DefaultDepartmentsCount()
        {
            Assert.AreEqual(4, Map.ListOfDepartments.Count);
        }

        internal void TitleIsChanged()
        {
            var expectedResult = "Finance Department";
            Assert.AreEqual(expectedResult, Map.MainTitleOfDepartment.Text);
        }

        internal void SettingsIconIsNotPresent()
        {
            Assert.IsTrue(Map.SettingsNotVisible);
        }
    }
}
