using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoetbalSpelersBusiness;

namespace VoetbalSpeler.Controllers
{
    public class TeamController : Controller
    {
        // GET: TeamController
        public ActionResult Index()
        {
            IClub club = new Club("ijfc");
            List<Team> teams = club.GetTeams();
            return View(teams);
        }

        // GET: TeamController/RankedList/5
        [HttpGet]
        public ActionResult RankedList(int id)
        {
            IRanking ranking = new Ranking();
            List<Player> players = ranking.GetRankedList(id);

            return View(players);
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            IClub club = new Club("ijfc");
            Team team = new Team(0, "teamname", 1);
            List<Coach> coaches = club.GetCoaches();
            return View(Tuple.Create(coaches, team));
        }

        // POST: TeamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                IClub club = new Club("ijfc");

                string teamname = Convert.ToString(collection["Item2.Teamname"]);
                string Coach = Convert.ToString(collection["Item2.CoachId"]);
                string[] words = Coach.Split(' ');
                int coachId = Int32.Parse(words[0]);
                Team team = new(0, teamname, coachId);

                club.Create(team);

                return RedirectToAction("Index", "Team");
            }
            catch
            {
                return RedirectToAction("Index", "Team");
            }
        }

        // GET: TeamController/Edit/5
        public ActionResult Edit(int id)
        {
            IClub club = new Club("ijfc");
            Team team = club.GetTeamById(id);
            List<Coach> coaches = club.GetCoaches();
            return View(Tuple.Create(coaches, team));
        }

        // POST: TeamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                IClub club = new Club("ijfc");

                string teamname = Convert.ToString(collection["Item2.Teamname"]);
                string Coach = Convert.ToString(collection["Item2.CoachId"]);
                string[] words = Coach.Split(' ');
                int coachId = Int32.Parse(words[0]);
                Team team = new(id, teamname, coachId);

                club.Edit(team);

                return RedirectToAction("Index", "Team");
            }
            catch
            {
                return RedirectToAction("Index", "Team");
            }
        }


    }
}
