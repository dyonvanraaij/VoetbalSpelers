﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoetbalSpelersBusiness;

namespace VoetbalSpeler.Controllers
{
    public class PlayerController : Controller
    {
        // GET: PlayerController
        public ActionResult Index(int id)
        {
            Club ijfc = new("ijfc");
            Team team = ijfc.GetTeamById(id);
            List<Player> spelers = team.GetPlayersByTeamId(id);
            return View(Tuple.Create(spelers, team));
        }

        // GET: PlayerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlayerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                string firstname = collection["Firstname"];
                string lastname = collection["Lastname"];
                string position = collection["Position"];
                int teamname = Int32.Parse(collection["Teamname"]);
                Club ijfc = new("ijfc");
                Team team = ijfc.GetTeamById(id);
                Player speler = new(1, firstname, lastname, position, id);
                team.AddPlayer(speler);
                return RedirectToAction("Index", "Player", new { id = id });
            }
            catch
            {
                return RedirectToAction("Index", "Player", new { id = id });
            }
        }

        //// GET: PlayerController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: PlayerController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
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