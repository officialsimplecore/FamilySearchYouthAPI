using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilySearchYouthAPI.Models
{
    public class RegionalInformation
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public int PeriodId { get; set; }
        public string Food { get; set; }
        public string Clothing { get; set; }
        public string Religion { get; set; }
        public string Weather { get; set; }
        public string Sports { get; set; }
        public string Music { get; set; }
        public string FamilyStructure { get; set; }
        public string Money { get; set; }
        public string Government { get; set; }
        public string Economy { get; set; }
        public string Technology { get; set; }
        public string Occupations { get; set; }
        public string Military { get; set; }
        public string HistoricalEvents { get; set; }
        public string Geography { get; set; }
        public string Wildlife { get; set; }
        public string Wars { get; set; }
        public string Migrations { get; set; }
        public string Folklore { get; set; }
        public string Holidays { get; set; }
        public string FamousPeople { get; set; }

        // Members only
        public string ChurchOfJesusChristOfLatterDaySaintsStory { get; set; }
        public string Temples { get; set; }
        public string Pioneers { get; set; }
    }
}
