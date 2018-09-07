using Pr_mini.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Pr_mini.Controllers
{
    public class MechanicController : Controller
    {
        //
        // GET: /Mechanic/
        public ActionResult Index()
        {
            return View();
        }

        Connection cnn = new Connection();

        public PartialViewResult SearchMechanic(int page, string MechanicNameSearch, int AreaIDSearch)
        {
            ViewBag.MechanicNameSearch = MechanicNameSearch;
            ViewBag.AreaIDSearch = AreaIDSearch;


            List<Mechanic> listMechanic = cnn.Mechanic.ToList();
            if (MechanicNameSearch != null && MechanicNameSearch.Length > 0)
            {
                listMechanic = listMechanic.Where(u => u.MechanicName.Contains(MechanicNameSearch)).ToList();
            }
            if (AreaIDSearch > 0){
                listMechanic = listMechanic.Where(u=>u.AreaID.Equals(AreaIDSearch)).ToList();
            }

            int rowInPage = 5;
            return PartialView("_ListMechanic",listMechanic.ToPagedList(page,rowInPage));
        }

        public String AddMechanic(string MechanicName, string Phone, string Address, int AreaID)
        {
            Mechanic mech = new Mechanic();
            mech.MechanicName = MechanicName;
            mech.Phone = Phone;
            mech.Address = Address;
            mech.AreaID = AreaID;
            mech.IsActive = 1;

            cnn.Mechanic.Add(mech);
            cnn.SaveChanges();

            return "Thêm thợ sửa xe thành công rùi đấy ahjhj";
        }

	}
}