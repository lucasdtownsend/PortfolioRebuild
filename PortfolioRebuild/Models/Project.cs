using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortfolioRebuild.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Timeline { get; set; }
        public string Summary { get; set; }
        public string Languages { get; set; }
        public string Screenshot { get; set; }
        public string GitHub { get; set; }
    }
}