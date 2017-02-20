using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FPL.Models
{
    [Serializable]
    public class Player
    {
        public string PlayerId { get; set; }
        public string WebName { get; set; }
        public string TeamCode { get; set; }
        public string Code { get; set; }
        public string FirtsName { get; set; }
        public string SecondName { get; set; }
        public string GoalsScored { get; set; }
        public string Assists { get; set; }
        public string CleenSheets { get; set; }
        public string GoalsConceded { get; set; }
        public string OwnGoals { get; set; }
        public string PenaltiesSaved { get; set; }
        public string PenaltiesMissed { get; set; }
        public string PointsPerGame { get; set; }

    }
}