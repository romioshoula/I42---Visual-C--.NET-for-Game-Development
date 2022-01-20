using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Problem1
{
    class EmployeeSearch
    {
        int[] nationalIDs;
        HireDate[] hireDates;
        String[] names;
        Employee[] employees;
        int length;
        int size;

        public int Length
        {
            get { return length; }
        }

        public EmployeeSearch(int _Size)
        {
            if (_Size <= 0) _Size = 1;
            size = _Size;
            nationalIDs = new int[size];
            hireDates = new HireDate[size];
            names = new String[size];
            employees = new Employee[size];
            length = 0;
        }

        //empSearch["123"] = emp;
        public Employee this [int nid]
        {
            get
            {
                for(int i=0;i<length;i++)
                {
                    if (nationalIDs[i] == nid)
                    {
                        return employees[i];
                    }
                }
                return new Employee();
            }

            set
            {
                bool overwrite = false;
                for (int i = 0; i < length; i++)
                {
                    if (nationalIDs[i] == nid)
                    {
                        employees[i] = value;
                        overwrite = true;
                    }
                }
                if (!overwrite)
                {
                    if(length<size)
                    {
                        nationalIDs[length] = nid;
                        employees[length] = value;
                        length++;
                    }
                }

            }
        }

        //empSearch["rami"] = emp;
        public Employee this[String nm]
        {
            get
            {
                for (int i = 0; i < length; i++)
                {
                    if (names[i] == nm)
                    {
                        return employees[i];
                    }
                }
                return new Employee();
            }

            set
            {
                bool overwrite = false;
                for (int i = 0; i < length; i++)
                {
                    if (names[i] == nm)
                    {
                        employees[i] = value;
                        overwrite = true;
                    }
                }
                if (!overwrite)
                {
                    if (length < size)
                    {
                        names[length] = nm;
                        employees[length] = value;
                        length++;
                    }
                }

            }
        }

        //empSearch[hd] = emp;
        public Employee this[HireDate hd]
        {
            get
            {
                for (int i = 0; i < length; i++)
                {
                    if (hireDates[i].CompareTo(hd)== 0)
                    {
                        return employees[i];
                    }
                }
                return new Employee();
            }

            set
            {
                bool overwrite = false;
                for (int i = 0; i < length; i++)
                {
                    if (hireDates[i].CompareTo(hd) == 0)
                    {
                        employees[i] = value;
                        overwrite = true;
                    }
                }
                if (!overwrite)
                {
                    if (length < size)
                    {
                        hireDates[length] = hd;
                        employees[length] = value;
                        length++;
                    }
                }

            }
        }
    }
}
