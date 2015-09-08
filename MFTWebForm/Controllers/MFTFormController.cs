using MFTWebForm.Models;
using MFTWebForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace MFTWebForm.Controllers {
    public class MFTFormController : Controller {
        private StudentService _service;

        public MFTFormController(StudentService service) {
            _service = service;
        }
        // GET: MFTForm
        public ActionResult Index() {
            TermsViewModel vm = new TermsViewModel();
            vm.Terms = _service.ListTerms(User.Identity.GetUserName());
            return View(vm);
        }

        // GET: MFTForm/Create
        public ActionResult NewTerm() {
            return View();
        }

        // POST: MFTForm/Create
        [HttpPost]
        public ActionResult NewTerm(TermDTO term) {
            try {
                _service.AddTerm(term, User.Identity.GetUserName());
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        public ActionResult NewEntry(string id) {
            MFTFormInputViewModel vm = new MFTFormInputViewModel();
            vm = _service.ReturnDropdowns();
            return View(vm);
        }

        [HttpPost]
        public ActionResult NewEntry(MFTFormSubmissionDTO MFTForm, string id) {
            try {
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

    }
}
