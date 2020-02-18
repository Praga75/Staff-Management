using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff.Data
{
    public class Staffs
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }

        public double Salary { get; set; }

        public Staffs(int staffId,string name,string department,string designation,double salary)
        {
            this.StaffId = staffId;
            this.Name = name;
            this.Department = department;
            this.Designation = designation;
            this.Salary = salary;
        }

        public Staffs()
        {

        }

    }
}
