using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qualif.Model
{
    public class JoinBookAndDetail
    {
        public int detailId { get; set; }  
        public int bookId { get; set; }
        public string title { get; set; }
        public DateTime duedate { get; set; }
    }
}