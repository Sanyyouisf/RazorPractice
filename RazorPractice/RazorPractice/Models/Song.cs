using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorPractice.Models
{
    public class Song
    {
        public string SongName { get; set; }
        public string Artist { get; set; }
        public string   Album { get; set; }
        public DateTime RecordedYear { get; set; }
    }
}