using MFTWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFTWebForm.Controllers
{
    public class InputDataController : Controller
    {
        private Repository _repo = new Repository();

        // GET: InputData
        public ActionResult Index()
        {
            var vm = new MFTFormViewModel();
            vm.Events = _repo.ListEvents();
            vm.ObservableData = _repo.ListObservableData();
            vm.Groups = _repo.ListGroups();
            vm.Supervisors = _repo.ListSupervisors();

            return View(vm);

        }

        [HttpPost]
        public ActionResult Index(MFTFormViewModel collection)
        {

            try
            {
                _repo.MFTFormSubmit(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: InputData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InputData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InputData/Create
        [HttpPost]
        public ActionResult Create(MFTFormSubmission collection)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InputData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InputData/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InputData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InputData/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
