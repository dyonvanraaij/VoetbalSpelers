using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoetbalSpelersBusiness;

namespace VoetbalSpeler.Controllers
{
    public class CoachController : Controller
    {
        // GET: CoachController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: CoachController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoachController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                IClub club = new Club("ijfc");

                string firstname = collection["Firstname"];
                string lastname = collection["Lastname"];
                Coach coach = new(1, firstname, lastname);
                club.CreateCoach(coach);
                return RedirectToAction("Index", "Team");
            }
            catch
            {
                return RedirectToAction("Index", "Team");
            }
        }

        //// GET: CoachController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: CoachController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

       
    }
}
