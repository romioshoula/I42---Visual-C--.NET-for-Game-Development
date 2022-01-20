using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Submission
{
    class Employee
    {
        public event
        EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff
       (EmployeeLayOffEventArgs e)
        {
            Console.Write($"Layed off Employee with ID: {this?.EmployeeID} ");
            Console.WriteLine($"Because {e.Cause}");
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
            get;
            set;
        }
        public int VacationStock
        {
            get;
            set;
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            if (From.CompareTo(To) > 0) return false;
            int reqDays = To.Subtract(From).Days;
            VacationStock -= reqDays;

            if (VacationStock < 0)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.employee_on_vacation });

            return VacationStock >= 0;
        }
        public void EndOfYearOperation()
        {
            DateTime retirement = BirthDate.AddYears(60);

            if (DateTime.Now.CompareTo(retirement) > 0)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.employee_retired });
        }

    }

    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.employee_failed_target });

            return AchievedTarget >= Quota;
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e?.Cause == LayOffCause.employee_failed_target || e?.Cause == LayOffCause.employee_retired)
                base.OnEmployeeLayOff(e);
        }
    }
    class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.employee_is_a_board_member });

        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e?.Cause == LayOffCause.employee_is_a_board_member)
                base.OnEmployeeLayOff(e);
        }
    }


    public enum LayOffCause
    { ///Implement it YourSelf 
        employee_retired, //retired employee
        employee_on_vacation, //vacation stock exceeded
        employee_failed_target, //failed to complete target
        employee_is_a_board_member //board member
    }
    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}