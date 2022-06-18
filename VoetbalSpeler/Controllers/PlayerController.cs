using Microsoft.AspNetCore.Http;
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
        private Club club;
        private TeamContainer teamContainer;
        private Team team;
        private Player player;

        public PlayerController(Club club, TeamContainer teamContainer, Team team, Player player)
        {
            this.club = club;
            this.teamContainer = teamContainer;
            this.team = team;
            this.player = player;
        }
        // GET: PlayerController
        public ActionResult Index(int id)
        {
            team.Id = id;
            Team selectedTeam = club.GetTeamById(team);
            List<Player> spelers = teamContainer.GetPlayersByTeamId(team);
            return View(Tuple.Create(spelers, selectedTeam));
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
                player.Id = 1;
                player.Firstname = firstname;
                player.Lastname = lastname;
                player.Position = position;
                player.Teamname = id;
                teamContainer.CreatePlayer(player);
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
