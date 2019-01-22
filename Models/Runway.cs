using System;
using System.ComponentModel.DataAnnotations;

namespace gust.Models
{
    public class Runway
    {
        [Key]
        public int runway_id { get; set; }
        public int airport_ref {get; set; }
        public string airport_ident {get; set; }
        public string le_ident {get; set; }
        public int le_heading_degT {get; set; }
        public string he_ident {get; set; }
        public int he_heading_degT {get; set; }
    }
}