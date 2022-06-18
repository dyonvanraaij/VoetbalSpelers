using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class coachDataTest : ICoachData
    {
        public void CreateCoach(CoachDTO coach)
        {

        }
        public List<CoachDTO> GetCoaches()
        {
            List<CoachDTO> coachList = new();
            coachList.Add(new CoachDTO { CoachId=1, Firstname="henk", Lastname="laatste" });
            coachList.Add(new CoachDTO { CoachId=2, Firstname="henktest2", Lastname="laatste231" });
            return coachList;
        }
    }
}
