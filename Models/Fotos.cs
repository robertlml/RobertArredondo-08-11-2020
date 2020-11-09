using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumirCli.Models
{
    public class Fotos
    {
        public int AlbumId { set; get; }
        public int Id { set; get; }
        public string Title { set; get; }
        public string Url { set; get; }
        public string ThumbnailUrl { set; get; }
    }
}