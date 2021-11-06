﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    /// <summary>
    /// This class is aimed at managing the data of a company
    /// </summary>
    public class Company
    {
        #region private attributes
        private string name; //company's name
        private List<Employee> lstEmployees; //company's employees's list
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
        /// this property gets the private attribute lstEmployee
        /// </summary>
        public List<Employee> LstEmployees
        {
            get { return null; }
            set { lstEmployees = null; }
        }
        #endregion accessors and mutators

        #region constructors
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name">name of the company</param>
        public Company(string name)
        {
           //TO DO
        }
        #endregion constructors

        #region public methods
        /// <summary>
        /// gets the company's employees's number
        /// </summary>
        /// <returns></returns>
        public int GetNbEmployees()
        {
            //TO DO
            return -1;
        }

        /// <summary>
        /// Adds an employee to the company's employees's list
        /// We check the employee to add is different from null before using it
        /// We check the employee list is not null before adding an employee (the list is created if it is null)
        /// </summary>
        /// <param name="emp">employee to add to the list</param>
        public void AddEmployee(Employee emp)
        {
            //TO DO
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
