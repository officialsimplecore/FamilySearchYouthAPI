using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilySearchYouthAPI.Models
{

    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string KmlUrl { get; set; }
        public RegionalInformation[] RegionalInformation{ get; set; }
    }
}
