using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ICoachData
    {
        public void CreateCoach(CoachDTO coach);
        public List<CoachDTO> GetCoaches();
    }
}
