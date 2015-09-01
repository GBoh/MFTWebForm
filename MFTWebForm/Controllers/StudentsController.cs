using MFTWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFTWebForm.Controllers
{
    public class StudentsController : Controller
    {
        private IRepository _repo;

        public StudentsController(Repository repo)
        {
            _repo = repo;
        }

        // GET: InputData
        public ActionResult InputData()
        {
            var vm = new MFTFormViewModel();
            vm.Events = _repo.Query<Event>().ToList();
            vm.ObservableData = _repo.Query<ObservableData>().ToList();
            vm.Groups = _repo.Query<Group>().ToList();
            vm.Supervisors = _repo.Query<Supervisor>().ToList();

            return View(vm);
        }

        [HttpPost]
        public ActionResult InputData(MFTFormSubmission model)
        {

            try
            {
                _repo.Add<MFTFormSubmission>(model);
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
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
