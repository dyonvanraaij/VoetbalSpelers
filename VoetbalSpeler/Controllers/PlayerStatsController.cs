using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoetbalSpelersBusiness;

namespace VoetbalSpeler.Controllers
{
    public class PlayerStatsController : Controller
    {

        private Club club;
        private Player player;
        private StatsContainer statsContainer;
        private Team team;

        public PlayerStatsController(Club club, Player player, StatsContainer statsContainer, Team team)
        {
            this.club = club;
            this.player = player;
            this.statsContainer = statsContainer;
            this.team = team;
        }
        // GET: StatsController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: StatsController/Details/5
        public ActionResult Details(int id)
        {
            player.Id = id;
            Player speler = club.GetPlayerById(player);
            Stats stats = player.GetStatsById(player);
            return View(Tuple.Create(speler, stats));
        }

        //// GET: StatsController/Edit/5
        public ActionResult Edit(int id)
        {
            // Stats weghalen en niet meegeven
            player.Id = id;
            Player speler = club.GetPlayerById(player);
            Stats stats = new(id,0,0,false,0,0,0,0,0,0,0);
            return View(Tuple.Create(speler, stats));
        }

        // POST: StatsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            if (id != 0)
            {
                try
                {
                    int player_id = id;
                    int goals = Int32.Parse(collection["Item2.Goals"]);
                    int assists = Int32.Parse(collection["Item2.Assists"]);
                    bool injury = false;
                    injury = collection["Item2.Injury"].Contains("true");
                    int keeper_clean = Int32.Parse(collection["Item2.KeeperClean"]);
                    int yellow = Int32.Parse(collection["Item2.Yellow"]);
                    int red = Int32.Parse(collection["Item2.Red"]);
                    int penal_held = Int32.Parse(collection["Item2.PenalHeld"]);
                    int penal_created = Int32.Parse(collection["Item2.PenalCreated"]);
                    int training = Int32.Parse(collection["Item2.Training"]);
                    int caused = Int32.Parse(collection["Item2.Caused"]);
                    Stats stats = new(player_id, goals, assists, injury, keeper_clean, yellow, red, penal_held, penal_created, training, caused);

                    player.Id = player_id;
                    team = club.GetTeamByPlayerId(player);

                    // Check for add or update
                    statsContainer.AddOrUpdateStats(stats);

                    // Get Team_id from player en give it to playerController index view
                    // View return goedzetten en alles terug zetten zodat het word toegevoegd of geupdate in database
                    return RedirectToAction("Index", "Player", new { id = team.Id });
                }
                catch (Exception)
                {
                    return RedirectToAction("Index", "Team");
                }
            }
            return RedirectToAction("Index", "Team");

        }

        //// GET: StatsController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: StatsController/Delete/5
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
