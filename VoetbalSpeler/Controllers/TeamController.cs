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
        private Club club;
        private Ranking ranking;
        private Team team;
        public TeamController(Club club, Ranking ranking, Team team)
        {
            this.club = club;
            this.ranking = ranking;
            this.team = team;
        }

        // GET: TeamController
        public ActionResult Index()
        {
            List<Team> teams = club.GetTeams();
            return View(teams);
        }

        // GET: TeamController/RankedList/5
        [HttpGet]
        public ActionResult RankedList(int id)
        {
            List<Player> players = ranking.GetRankedList(id);

            return View(players);
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            team.Id = 0;
            team.Teamname = "teamname";
            team.CoachId = 1;
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
                string teamname = Convert.ToString(collection["Item2.Teamname"]);
                string Coach = Convert.ToString(collection["Item2.CoachId"]);
                string[] words = Coach.Split(' ');
                int coachId = Int32.Parse(words[0]);
                team.Id = 0;
                team.Teamname = teamname;
                team.CoachId = coachId;
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
            team.Id = id;
            Team selectedTeam = club.GetTeamById(team);
            List<Coach> coaches = club.GetCoaches();
            return View(Tuple.Create(coaches, selectedTeam));
        }

        // POST: TeamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                string teamname = Convert.ToString(collection["Item2.Teamname"]);
                string Coach = Convert.ToString(collection["Item2.CoachId"]);
                string[] words = Coach.Split(' ');
                int coachId = Int32.Parse(words[0]);

                team.Id = id;
                team.Teamname = teamname;
                team.CoachId = coachId;
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
