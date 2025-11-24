using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Class
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OrgName { get; set; }
        public string Description { get; set; }
        public string Deadline { get; set; }
        public decimal Budget { get; set; }
        public string Prerequisites { get; set; }

       
        public string ImageUrl { get; set; }
        public string CreatedBy { get; set; }
    }

    // Bid project class

    public class BidProject
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public bool IsCompleted { get; set; }
    }

}
