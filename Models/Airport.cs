using System;
using System.ComponentModel.DataAnnotations;
namespace gust.Models
{
    public class Airport
    {
        [Key]
        public int airport_id { get; set; }
        public string ident { get; set; }
        public string airport_name { get; set; }
        public decimal latitude_deg { get; set; }
        public decimal longitude_deg { get; set; }
        public string iso_country { get; set; }
        public string iso_region { get; set; }
    }
}
