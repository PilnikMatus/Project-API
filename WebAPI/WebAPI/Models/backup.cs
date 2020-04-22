using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class backup
    {
        public int id { get; set; }
        public string id_admin { get; set; }
        public string name { get; set; }
        public string backup_type { get; set; }
        public string format_type { get; set; }
        public DateTime last_possible_backup_date { get; set; }
        public bool active { get; set; }
    }
}