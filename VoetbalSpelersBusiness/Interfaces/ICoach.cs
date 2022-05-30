using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public interface ICoach
    {
        public int CoachId { get; }
        public string Firstname { get; }
        public string Lastname { get; }
    }
}
