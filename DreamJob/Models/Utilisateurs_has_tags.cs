using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamJob.Models
{
    public class Utilisateurs_has_tags
    {
        public int id { get; set; }

        public int id_user { get; set; }

        public int id_tags { get; set; }
    }
}