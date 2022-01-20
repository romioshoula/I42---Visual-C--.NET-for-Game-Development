using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normal employees
            #region Normal employees

            //Employee Layed off bec. of Vacation
            Employee emp1 = new Employee();
            emp1.EmployeeID = 1;
            emp1.BirthDate = DateTime.Now; //young
            emp1.VacationStock = 0; //0 vacations left

            //Employee Layed off bec. of Retiration
            Employee emp2 = new Employee();
            emp2.EmployeeID = 2;
            DateTime E2Bdate = new DateTime(1935, 01, 10);

            emp2.BirthDate = E2Bdate; //Old and Retired
            emp2.VacationStock = 150; //150 vacations left

            #endregion
            //

            //Sales Persons employees
            #region Sales Persons employees

            SalesPerson SP = new SalesPerson();
            SP.EmployeeID = 3;
            SP.BirthDate = DateTime.Now; // young
            SP.VacationStock = -1; //-1 vacations left
            SP.AchievedTarget = 10;

            #endregion
            //

            //Board members
            #region Board members

            BoardMember BM = new BoardMember();
            BM.EmployeeID = 4;
            BM.BirthDate = emp2.BirthDate; //old
            BM.VacationStock = -1; //-1 vacations left

            #endregion
            //

            //Department creation
            #region Department creation

            Department Dept = new Department();
            Dept.DeptName = "Sales Department";
            Dept.DeptID = 1;
            Dept.AddStaff(emp1);
            Dept.AddStaff(emp2);
            Dept.AddStaff(SP);
            Dept.AddStaff(BM);

            #endregion
            //

            //Club Creation
            #region Club Creation

            Club club = new Club();
            club.ClubID = 1;
            club.ClubName = "Company Club: Bad Boys";
            club.AddMember(emp1);
            club.AddMember(emp2);
            club.AddMember(SP);
            club.AddMember(BM);

            #endregion
            //

            //Operations
            #region Operations
            emp1.EndOfYearOperation();
            emp1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(2));

            emp2.EndOfYearOperation();
            emp2.RequestVacation(DateTime.Now, DateTime.Now.AddDays(2));

            SP.EndOfYearOperation();
            SP.RequestVacation(DateTime.Now, DateTime.Now.AddDays(2));
            SP.CheckTarget(100); //didn't acheive set goal (target)

            BM.EndOfYearOperation();
            BM.RequestVacation(DateTime.Now, DateTime.Now.AddDays(2));
            BM.Resign(); //employee resigned

            #endregion
            //
        }
    }
}
