using NUnit.Framework;
using EmployeeManagement;
using System;
using System.Collections.Generic;

namespace EmployeeMgtTests
{
    [TestFixture]
    public class CompanyTests 
    {
        private Company comp; 
        Employee empSon; 
        Employee empHatte;

        /// This method aimed at initializing all the variables used in all our tests methods
        /// This method is called before each test
        [SetUp]
        public void Company_Init()
        {
            comp = new Company("video game SC");
            empSon = new Employee("Son", "Patty", 1, DateTime.Parse("31.08.2020"), 4000.00);
            empHatte = new Employee("Hatte", "Tom", 1, DateTime.Parse("31.08.2020"), 4000.00);
        }


        /// <summary>
        /// This test method is designed to test
        /// Scenario : We create two employees and add them in the company's employees's list 
        /// Expected result : the number of the company's employees
        /// </summary>
        [Test]
        public void GetNbEmployees_2Employees_NumberEmployeesOK()
        {
            //init
            comp.LstEmployees = new List<Employee>();
            comp.LstEmployees.Add(empSon);
            comp.LstEmployees.Add(empHatte);
            int nbEmpExpected = 2;

            //when
            int nbEmpActual = comp.GetNbEmployees();

            //check
            Assert.AreEqual(nbEmpExpected, nbEmpActual);
        }

        /// <summary>
        /// This test method is designed to test the AddEmployee Methode
        /// Scenario :  We create two employees and add them in the company's employees's list 
        /// Expected result : the two employees are part of the company's list
        /// </summary>
        [Test]
        public void AddEmployee_Add2Employees_ListEmployeesOK()
        {
            //init
            List<Employee> lstEmployeeExpected = new List<Employee>();
            lstEmployeeExpected.Add(empSon);
            lstEmployeeExpected.Add(empHatte);

            //when
            comp.AddEmployee(empHatte);
            comp.AddEmployee(empSon);

            List<Employee> lstEmployeesActual = comp.LstEmployees;
            CollectionAssert.AreEquivalent(lstEmployeeExpected, lstEmployeesActual);
        }
        
    }
}