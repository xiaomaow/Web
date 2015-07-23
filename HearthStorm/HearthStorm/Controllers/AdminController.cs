using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HearthStorm.Models;

namespace HearthStorm.Controllers
{
    public class AdminController : Controller
    {

        private DBContext _db = new DBContext();
        //
        // GET: /Admin/

        /// <summary>
        /// 获得管理员列表
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminList()
        {
            try
            {
                var AdminList = (from entry in _db.AdminEntries select entry);
                ViewBag.Entries = AdminList.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View();
        }

    }
}
