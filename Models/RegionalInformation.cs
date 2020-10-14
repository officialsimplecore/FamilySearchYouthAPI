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
        public CardItem Food { get; set; }
        public CardItem Clothing { get; set; }
        public CardItem Religion { get; set; }
        public CardItem Weather { get; set; }
        public CardItem Sports { get; set; }
        public CardItem Music { get; set; }
        public CardItem FamilyStructure { get; set; }
        public CardItem Money { get; set; }
        public CardItem Government { get; set; }
        public CardItem Economy { get; set; }
        public CardItem Technology { get; set; }
        public CardItem Occupations { get; set; }
        public CardItem Military { get; set; }
        public CardItem HistoricalEvents { get; set; }
        public CardItem Geography { get; set; }
        public CardItem Wildlife { get; set; }
        public CardItem Wars { get; set; }
        public CardItem Migrations { get; set; }
        public CardItem HolidaysandFolklore { get; set; }
        public CardItem FamousPeople { get; set; }

        // Members only
        public string TheChurchStory { get; set; }
        public string Temples { get; set; }
        public string Pioneers { get; set; }
    }
}
