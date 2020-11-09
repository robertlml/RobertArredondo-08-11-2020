using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumirCli.Models
{
    public class Comentarios
    {
        public int PostId { set; get; }
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Email { set; get; }
        public string Body { set; get; }
    }
}