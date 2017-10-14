using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorPractice.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public DateTime RecordingDate { get; set; }
        public string Auther { get; set; }
    }
}