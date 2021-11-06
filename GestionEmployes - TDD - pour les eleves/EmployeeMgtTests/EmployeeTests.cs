using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmployeeManagement;

namespace EmployeeMgtTests
{
    [TestFixture]
    public class EmployeeTests
    {
        #region private attributes
        private Employee empSon; //utilisé pour stocker l'objet Employe
        #endregion private attributes

        /// This method aimed at initializing all the variables used in all our tests methods
        /// This method is called before each test
        [SetUp]
        public void Employee_Init()
        {
            empSon = new Employee("Son", "Patty", 1, DateTime.Parse("10.11.2020"), 4000.00);
        }

        /// <summary>
        /// This test method is designed to test the constructor
        /// Scenario : We use the 5 parameters of the constructor (name, firstname, level, hire date and salary)
        /// Expected result : the employee's name
        /// </summary>
        [Test]
        public void Employee_Constructor_5Parameters_GetName()
        {
            //prep data
            string nameExpected = "Son";

            //execution - when
            String nameActual = empSon.Name;

            //check
            Assert.AreEqual(nameExpected, nameActual);
        }

        /// <summary>
        /// Scenario : We use the 5 parameters of the constructor (name, firstname, level, hire date and salary)
        /// Expected result : the employee's firstname
        /// </summary>
        [Test]
        public void Employee_Constructor_5Parameters_GetFirstName()
        {
            //prep data
            string firstNameExpected = "Patty";

            //when
            String firstNameActual = empSon.FirstName;

            //check
            Assert.AreEqual(firstNameExpected, firstNameActual);
        }

        /// <summary>
        /// This test method is designed to test the constructor
        /// Scenario : We use the 5 parameters of the constructor (name, firstname, level, hire date and salary)
        /// Expected result : the employee's hiredate
        /// </summary>
        [Test]
        public void Employee_Constructor_5Parameters_GetHireDate()
        {
            //prep
            DateTime dateHiringExpected = DateTime.Parse("10.11.2020");

            //when
            DateTime dateHiringActual = empSon.HireDate;

            //check
            Assert.AreEqual(dateHiringExpected, dateHiringActual);
        }

        /// <summary>
        /// This test method is designed to test the constructor
        /// Scenario : We use the 5 parameters of the constructor (name, firstname, level, hire date and salary)
        /// Expected result : the employee's level
        /// </summary>
        [Test]
        public void Employee_Constructor_5Parameters_GetLevel()
        {
            //prep
            int levelExpected = 1;

            //when
            int levelActual = empSon.Level;

            //check
            Assert.AreEqual(levelExpected, levelActual);
        }

        /// <summary>
        /// This test method is designed to test the constructor
        /// Scenario : We use the 5 parameters of the constructor (name, firstname, level, hire date and income)
        /// Expected result : the employee's income
        /// </summary>
        [Test]
        public void Employee_Constructor_5Parameters_GetSalary()
        {
            //prep
            double salaryExpected = 4000.00;

            //when
            double salaryActual = empSon.Salary;

            //check
            Assert.AreEqual(salaryExpected, salaryActual);
        }

        /// <summary>
        /// Scenario : We create an "employee" object and call the method to calculate the employee's seniority (ancienneté)
        /// the hire date's month is less than the current month
        /// Expected result : the employees's seniority in the company
        /// </summary>
        [Test]
        public void Employee_CalculateSeniority_DateInThePastMoreThan1YearMonthBefore_NbYearMoreThanZeroOK()
        {
            //construction données
            Employee empHatte = new Employee("Hatte", "Tom", 1, DateTime.Parse("10.02.2013"), 4000.00);
            int yearExpected = 8;
            //appel de la fonction
            int yearActual = empHatte.CalculateSeniority();
            //verif
            Assert.AreEqual(yearExpected, yearActual);
        }

        /// <summary>
        /// Scenario : We create an "employee" object and call the method to calculate the employee's seniority (ancienneté)
        /// the hire date's month is higher than the current month
        /// Expected result : the employees's seniority in the company
        [Test]
        public void Employee_CalculateSeniority_DateInThePastLessThan1YearMonthAfter_NbYearEqualZeroOK()
        {
            int yearExpected = 0;
            int yearActual = empSon.CalculateSeniority();
            Assert.AreEqual(yearExpected, yearActual);
        }

        /// <summary>
        /// Scenario : We create an "employee" object and call the method to calculate the employee's salary increase
        /// The employee's level changes
        /// Expected result : the employees's new income
        [Test]
        public void Employee_IncreasingSalary_ChangeLevel_SalaryOK()
        {
            //given
            double salaryExpected = 4400.00;
            //when
            empSon.SalaryIncreasing(1, 2);
            double salaryCalculated = empSon.Salary;
            //check
            Assert.AreEqual(salaryExpected, salaryCalculated);
        }

        /// <summary>
        /// Scenario : We create an "employee" object and call the method to calculate the employee's salary increase
        /// The employee's level does not change
        /// Expected result : the employees's new income
        [Test]
        public void Employee_SalaryIncreasing_LevelEqual_SalaryOK()
        {
            //given
            double salaryExpected = 4100.00;
            //when
            empSon.SalaryIncreasing(1, 1);
            double salaryCalculated = empSon.Salary;
            //check
            Assert.AreEqual(salaryExpected, salaryCalculated);
        }

        /// <summary>
        /// Scenario : We create an "employee" object and call the method Promotion on this object, 
        /// the employee has been hired this year (seniority is 0)
        /// Expected result : the employees's level is the same
        [Test]
        public void Employee_Promotion_SeniorityZero_LevelUnchanged()
        {
            //given
            double levelExpected = 1;
            //when
            empSon.Promotion();
            double levelCalculated = empSon.Level;
            //check
            Assert.AreEqual(levelExpected, levelCalculated);
        }

        /// <summary>
        /// Scenario : We create an "employee" object and call the method Promotion on this object,
        /// the employee is here in the company from a certain amount of years which is multiple of 5
        /// Expected result : the employees's level increases of one
        [Test]
        public void Employee_Promotion_YearMultipleOf5_LevelChanged()
        {
            Employee empHatte = new Employee("Hatte", "Tom", 2, DateTime.Parse("10.08.2016"), 4000.00);
            //given
            double levelExpected = 3;
            //when
            empHatte.Promotion();
            double levelCalculated = empHatte.Level;
            //check
            Assert.AreEqual(levelExpected, levelCalculated);
        }

        /// <summary>
        /// Scenario : We create an "employee" object and call the method Promotion on this object,
        /// the employee is here in the company from a certain amount of years which is not multiple of 5
        /// Expected result : the employees's level remains the same
        [Test]
        public void Employee_Promotion_YearNotMultipleOf5_LevelUnchange()
        {
            Employee empHatte = new Employee("Hatte", "Tom", 2, DateTime.Parse("30.11.2016"), 4000.00);
            //given
            double levelExpected = 2;
            //when
            empHatte.Promotion();
            double levelCalculated = empHatte.Level;
            //check
            Assert.AreEqual(levelExpected, levelCalculated);
        }
    }
}
