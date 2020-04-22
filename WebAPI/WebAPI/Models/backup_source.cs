using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class backup_source
    {
        public int id { get; set; }
        public int id_backup { get; set; }
        public string path { get; set; }
    }
}