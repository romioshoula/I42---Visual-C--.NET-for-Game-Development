using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Submission
{
    class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;
        public void AddMember(Employee E)
        {
            if (Members == null) { Members = new List<Employee>(); }

            if (E != null)
            {
                Members.Add(E);
                E.EmployeeLayOff += RemoveMember;
            }
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember
       (object sender, EmployeeLayOffEventArgs e)
        {

            if (e?.Cause != LayOffCause.employee_retired && e?.Cause != LayOffCause.employee_is_a_board_member)
            {
                if (sender == null) return;
                if (sender is Employee Emp)
                    Members?.Remove(Emp);
                //else employee is a club member
            }
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
    }
}
