using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamJob.Models
{
    public class Favoris
    {
        public int id { get; set; }

        public int id_user { get; set; }

        public int id_article { get; set; }
    }
}