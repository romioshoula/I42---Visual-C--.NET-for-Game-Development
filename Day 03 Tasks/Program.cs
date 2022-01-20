using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Enum.Parse(typeof(Gender),"M"));
            Employee[] EmpArr = new Employee[3];
            for (int i = 0; i < 3; i++)
            {
               
                int ID = -1;
                while (ID < 1)
                {
                    Console.WriteLine("Enter Unique National ID: ");
                    String x = Console.ReadLine();
                    int val;
                    if(int.TryParse(x,out val) == true)
                    {
                        ID = val;
                        if (ID < 1) Console.WriteLine("Invalid ID, please try again");
                    }
                    else
                    {
                        Console.WriteLine("Invalid format, please try again");
                    }
                }

                String NAME = "";
                while(NAME=="")
                {
                    Console.WriteLine("Enter Name: ");
                    NAME = String.Format(Console.ReadLine());
                }


                SecurityPriveleges SL = (SecurityPriveleges)0;
                while (SL == (SecurityPriveleges)0)
                {
                    Console.WriteLine("Enter Security Level (Priveleges Should be Separated by only One Space): ");
                    String x = Console.ReadLine();
                    String[] arr = x.Split();

                    bool itr = true;
                    SecurityPriveleges val;
                    for(int j=0;j<arr?.Length && itr ;j++)
                    {
                        SL ^= Enum.TryParse(arr[j], true, out val)? val:(SecurityPriveleges)0;
                        if(SL==(SecurityPriveleges)0)
                        {
                            Console.WriteLine("Invalid Privelege, Please try again (guest developer secretary dba)");
                            itr = false;
                        }    

                    }
                }
         

                float Sal = -1;
                while (Sal < 200)
                {
                    Console.WriteLine("Enter Salary: ");
                    String x = Console.ReadLine();
                    float val;
                    if (float.TryParse(x, out val) == true)
                    {
                        Sal = val;
                        if (Sal < 200) Console.WriteLine("Invalid Salary Level, please try again");
                    }
                    else
                    {
                        Console.WriteLine("Invalid format, please try again");
                    }
                }
              
                Gender gen = (Gender)7;
                while (gen != Gender.F && gen!= Gender.M)
                {

                    Console.WriteLine("Enter Gender (M or m: for male & F or f: for female)");
                    String x = Console.ReadLine().ToUpper();
                    Gender val;

                    if (Enum.TryParse(x,true, out val)==true)
                    {
                        gen = val;
                    }
                    else gen = (Gender)7;


                    if (gen != Gender.F && gen != Gender.M)
                        Console.WriteLine("Invalid Gender, Please Try Again: ");
          
                }


                int d = -1, m = -1, y = -1;
                while (d <= 0 || d > 31 || m <= 0 || m > 12 || y <= 1900 || y > 2022)
                {
                    Console.WriteLine("Enter Hiredate:");
                    String HD = Console.ReadLine();
                    String[] arr = HD.Split('/');

                    if (arr.Length == 3)
                    {
                        int val;
                        d = arr[0] == null ? -1 : int.TryParse(arr[0], out val)? val : -1;

                        m = arr[1] == null ? -1 : int.TryParse(arr[1], out val)? val : -1;

                        y = arr[2] == null ? -1 : int.TryParse(arr[2], out val)? val : -1;
                    }

                    if (arr.Length != 3)
                        Console.WriteLine("Invalid Format");
                    else if (d <= 0 || d > 31)
                        Console.WriteLine("Invalid Day, Please try again");
                    else if (m <= 0 || m > 12)
                        Console.WriteLine("Invalid Month, Please try again");
                    else if (y <= 1900 || y > 2022)
                        Console.WriteLine("Invalid year, Please try again");
                }



                EmpArr[i] = new Employee(ID,NAME, SL, Sal, gen, d, m, y);
                Console.WriteLine("");
                Console.WriteLine("You Entered: ");
                Console.WriteLine(EmpArr[i].ToString());
                Console.WriteLine("");
            }

            Array.Sort(EmpArr);
            for(int i = 0; i < EmpArr?.Length; i++)
            {
                Console.WriteLine(EmpArr[i].ToString());
            }
            Console.WriteLine("");

            EmployeeSearch empSearch = new EmployeeSearch(3);
            empSearch[EmpArr[0].ID] = EmpArr[0];
            empSearch[EmpArr[1].EmpHireDate] = EmpArr[1];
            empSearch[EmpArr[2].Name] = EmpArr[2];

            Console.WriteLine(empSearch[EmpArr[0].ID]);
            Console.WriteLine("");

            Console.WriteLine(empSearch[EmpArr[1].EmpHireDate]);
            Console.WriteLine("");

            Console.WriteLine(empSearch[EmpArr[2].Name]);
            Console.WriteLine("");


        }
    }
}
