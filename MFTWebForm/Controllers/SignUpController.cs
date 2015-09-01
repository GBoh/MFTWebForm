using MFTWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFTWebForm.Controllers
{
    public class SignUpController : Controller
    {
        private IRepository _repo;

        public SignUpController(Repository repo)
        {
            _repo = repo;
        }

        // GET: SignUp
        public ActionResult Index()
        {
            return View();
        }

        // GET: SignUp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
