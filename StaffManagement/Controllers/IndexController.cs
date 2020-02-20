using System.Collections.Generic;
using System.Web.Mvc;
using Staff.Data;
using Staff.Repository;

namespace StaffManagement.Controllers
{
    public class IndexController : Controller
    {
        Repository staffRepository;
        public IndexController()
        {
            staffRepository = new Repository();
        }
        // GET: Index
        public ActionResult Index()
        {
            IEnumerable<Staffs> staffs = staffRepository.GetStaffsInfo();
            return View(staffs);
        }
        //Adding Staff detail without Update Model
        //public ActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Create(Staffs staff)
        //{
        //    staffRepository.AddStaff(staff);
        //    TempData["Message"] = "Staff Detail Added Successfully!";
        //    return RedirectToAction("Index");
        //}

        //Adding Staff Detail with Update Model
        //[HttpGet]
        //[ActionName("Create")]
        //public ActionResult Create_Get()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_Post()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Repository repository = new Repository();
        //        Staffs staffs = new Staffs();
        //        UpdateModel<Staffs>(staffs);
        //        repository.AddStaff(staffs);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //Adding Staff Detail with TryUpdate Model
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            Repository repository = new Repository();
            Staffs staffs = new Staffs();
            TryUpdateModel(staffs);
            if (ModelState.IsValid)
            {
                repository.AddStaff(staffs);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            staffRepository.DeleteStaff(id);
            TempData["Message"] = "Staff Detail Deleted Successfully!";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Staffs staffs = staffRepository.GetStaff(id);
            return View(staffs);
        }
        [HttpPost]
        public ActionResult Update(Staffs staff)
        {
            staffRepository.UpdateStaff(staff);
            TempData["Message"] = "Employee Details Updated Successfully";
            return RedirectToAction("Index");
        }
    }
}