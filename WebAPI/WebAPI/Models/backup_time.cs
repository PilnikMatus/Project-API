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
        public int id_backup { get; set; }
        public DateTime start_time { get; set; }
        public string repetation_unit { get; set; }
        public int repetation_number { get; set; }
    }
}