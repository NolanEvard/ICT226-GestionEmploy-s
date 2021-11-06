using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement;

namespace EmployeeManagementConsole
{
    class Program
    {
        //Creating a company and test employees
        static private Company company = new Company("testCompany");


    static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Employee employee = new Employee("Name" + i.ToString(), "firstname" + i.ToString(), 1, DateTime.Parse("06.11.201" + i.ToString()), 4000 + 100 * i);
                company.AddEmployee(employee);
            }

            readChoice(displayMainMenu());
        }
        static void WriteInConsole(string message)
        {
            Console.Clear();
            Console.Write(message);
        }
        static int displayMainMenu()
        {
            string menu = @"
 -------------------------------------------
|        Employee Management                |
 -------------------------------------------

1. Lister le nombre d'employés de la société
2. Afficher les caractéristique de la société
3. Lister les employés de l'entreprise
0. Quitter

Votre choix: ";
            WriteInConsole(menu);
            string choice = Console.ReadLine();
            return int.Parse(choice);
        }

        static void readChoice(int choice)
        {
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    getNumber();
                    readChoice(displayMainMenu());
                    break;
                case 2:
                    getCompanyInfo();
                    readChoice(displayMainMenu());
                    break;
                case 3:
                    getEmployees();
                    readChoice(displayMainMenu());
                    break;
                default:
                    break;
            }
        }
        static void getNumber()
        {
            int numberOfEmployees = company.GetNbEmployees();

            string message = @"
Le nombre d'employés est de " + numberOfEmployees.ToString() + " employés";
            WriteInConsole(message);
            Console.ReadKey();
        }

        static void getCompanyInfo()
        {
            string companyName = company.Name;
            string message = @"
            Informations de la companie:
-----------------------------------------------------
Nom de la companie: " + companyName.ToString();
            WriteInConsole(message);
            Console.ReadKey();
        }

        static void getEmployees()
        {
            string name, firstname, message;
            int level, seniority;
            DateTime hireDate;
            double salary;

            message = @"
            Liste des Employés
--------------------------------------------
";
            Console.Clear();
            Console.WriteLine(message);

            for (int i = 0; i < company.GetNbEmployees(); i++)
            {
                name = company.LstEmployees[i].Name;
                firstname = company.LstEmployees[i].FirstName;
                level = company.LstEmployees[i].Level;
                seniority = company.LstEmployees[i].CalculateSeniority();
                hireDate = company.LstEmployees[i].HireDate;
                salary = company.LstEmployees[i].Salary;

                message = @"
Employés n°" + i.ToString() + @"
-----------------
Nom : " + name + @"
Prénom : " + firstname + @"
Date d'engagement : " + hireDate.ToString("dd/MM/yyyy") + @"
Année(s) d'ancieneté : " + seniority.ToString() + @" année(s)
Niveau dans l'entreprise : " + level.ToString() + @"
Salaire : " + salary.ToString() + "\n\n";
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
    }
}
