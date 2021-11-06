using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    /// <summary>
    /// This class is aimed at managing the data of an employee
    /// </summary>
    public class Employee
    {
        #region private attributes
        private string name; //employee's name
        private string firstname; //employee's firstname
        private int level; //employee's level
        private DateTime hireDate; //employee's hire date
        private double salary; //employee's salary
        #endregion private attributes

        #region accessors and mutators
        /// <summary>
        /// this property gets the private attribute name
        /// </summary>
        public string Name
        {
            get { return null; }
        }

        /// <summary>
        /// this property gets the private attribute firstname
        /// </summary>
        public string FirstName
        {
            get { return null; }
        }

        /// <summary>
        /// this property gets the private attribute level
        /// </summary>
        public int Level
        {
            get { return -1; }
        }

        /// <summary>
        /// this property gets the private attribute hiredate
        /// </summary>
        public DateTime HireDate
        {
            get { return DateTime.Now; }
        }

        /// <summary>
        /// this property gets the private attribute salary
        /// </summary>
        public double Salary
        {
            get { return -1; }
        }
        #endregion accessors and mutators

        #region constructors
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name">contains the name that will initialize the employee's name</param>
        /// <param name="firstname">contains the firstname that will initialize the employee's firstname</param>
        /// <param name="level">contains the level that will initialize the employee's level</param>
        /// <param name="dateEmbauche">contains the hiredate that will initialize the employee's hiredate</param>
        /// <param name="salary">contains the salary that will initialize the employee's salary</param>
        public Employee(string name, string firstname, int level, DateTime hireDate, double salary)
        {
            //TO DO
        }
        #endregion constructors

        #region public methods
        /// <summary>
        /// Calculate the employee's seniority
        /// We get the difference between the hire date's year and the current date's year
        /// If the number of years of seniority + the hire date est higher than the current date, we remove one year
        /// </summary>
        /// <returns>le number of years completly done since the employee's hiring</returns>
        public int CalculateSeniority()
        {
            //TO DO
            return -1;
        }

        /// <summary>
        /// Salary management
        /// If the employee's level increases by 1, his/her salary increases by 0.1.
        /// If the employee's level is the same, his/her salary increases by 0.025.
        /// </summary>
        /// <param name="prevLevel">employee's previous level</param>
        /// <param name="newLevel">new level for the new year</param>
        public void SalaryIncreasing(int prevLevel, int newLevel)
        {
            //TO DO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Employee's level management
        /// Every 5 years that are completed done by the employee and if the employee is in the company for more than one year,
        /// the employee's level increases by 1.
        /// </summary>
        public void Promotion()
        {
            //TO DO
            throw new NotImplementedException();
        }
        #endregion public methods

    }
}
