using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Problem1
{
    public enum Gender
    {
        M, F
    }

    public struct Employee
    {
        int id;
        float salary;
        Date hireDate;
        Gender gender;

        public Employee(int ID, float Sal,Gender G, int d,int m, int y )
        {
            id = ID;
            salary = Sal;
            gender = G;
            hireDate = new Date(d, m, y);

        }

        public override string ToString()
        {
            StringBuilder data = new StringBuilder("", 100);
            data.Append($"Employee ID: {id} \n");
            data.Append($"Salary: {salary.ToString("C")} \n");
            data.Append($"Gender: {gender} \n");
            data.Append($"Hiredate: {hireDate.getDay()}/{hireDate.getMonth()}/{hireDate.getyear()}");

            return data.ToString();
        }

    }
}
