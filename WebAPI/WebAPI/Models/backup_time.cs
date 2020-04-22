using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class backup_time
    {
        public int id { get; set; }
        public string id_backup { get; set; }
        public DateTime starttime { get; set; }
        public string repetation_unit { get; set; }
        public int repetation_number { get; set; }
    }
}