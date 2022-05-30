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
        // GET: StatsController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: StatsController/Details/5
        public ActionResult Details(int id)
        {
            IClub club = new Club("ijfc");
            IPlayer player = club.GetPlayerById(id);
            Stats stats = player.GetStatsById(id);
            return View(Tuple.Create(player,stats));
        }

        //// GET: StatsController/Edit/5
        public ActionResult Edit(int id)
        {
            // Stats weghalen en niet meegeven
            IClub club = new Club("ijfc");
            IPlayer player = club.GetPlayerById(id);
            Stats stats = new(id,0,0,false,0,0,0,0,0,0,0);
            return View(Tuple.Create(player, stats));
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
                    int keeper_clean = Int32.Parse(collection["Item2.Keeper_clean"]);
                    int yellow = Int32.Parse(collection["Item2.Yellow"]);
                    int red = Int32.Parse(collection["Item2.Red"]);
                    int penal_held = Int32.Parse(collection["Item2.Penal_held"]);
                    int penal_created = Int32.Parse(collection["Item2.Penal_created"]);
                    int training = Int32.Parse(collection["Item2.Training"]);
                    int caused = Int32.Parse(collection["Item2.Caused"]);
                    Stats stats = new(player_id, goals, assists, injury, keeper_clean, yellow, red, penal_held, penal_created, training, caused);

                    // Check for add or update
                    IClub club = new Club("ijfc");
                    int teamId = club.GetTeamByPlayerId(player_id);
                    IPlayer speler = club.GetPlayerById(player_id);
                    Stats oldStats = speler.GetStatsById(id);
                    if (oldStats.Player_id == 0)
                    {
                        speler.AddStats(stats);
                    } else
                    {
                        goals += oldStats.Goals;
                        assists += oldStats.Assists;
                        keeper_clean += oldStats.Keeper_clean;
                        yellow += oldStats.Yellow;
                        red += oldStats.Red;
                        penal_held += oldStats.Penal_held;
                        penal_created += oldStats.Penal_created;
                        caused += oldStats.Caused;
                        Stats updatedStats = new(player_id, goals, assists, injury, keeper_clean, yellow, red, penal_held, penal_created, training, caused);
                        speler.UpdateStats(updatedStats);
                    }

                    // Get Team_id from player en give it to playerController index view
                    // View return goedzetten en alles terug zetten zodat het word toegevoegd of geupdate in database
                    return RedirectToAction("Index", "Player", new { id = teamId });
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
