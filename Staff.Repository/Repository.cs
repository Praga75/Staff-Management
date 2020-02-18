using Staff.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff.Repository
{
    public class Repository
    {
        public static List<Data.Staffs> staffs = new List<Data.Staffs>();
        static Repository()
        {
            staffs.Add(new Staffs(122,"Praga","ECE","Head of the Department",40000.00));
            staffs.Add(new Staffs(123,"Siva", "Food Technology", "Head of the Department", 40000.00));
            staffs.Add(new Staffs(124,"Kannamma", "CSE", "Head of the Department", 40000.00));

        }
        public IEnumerable<Staffs> GetStaffsInfo()
        {
            return staffs;
        }
        public void AddStaff(Staffs staff)
        {
            staffs.Add(staff);
        }
        public Staffs GetStaff(int staffId)
        {
            return staffs.Find(id => id.StaffId == staffId);
        }
        public void DeleteStaff(int staffId)
        {
            Staffs staff = GetStaff(staffId);
            if (staff != null)
                staffs.Remove(staff);
        }
        public void UpdateStaff(Staffs staff)
        {
            Staffs staffs = GetStaff(staff.StaffId);
            staffs.Name = staff.Name;
            staffs.Department = staff.Department;
            staffs.Designation = staff.Designation;
            staffs.Salary = staff.Salary;

        }
    }
}
