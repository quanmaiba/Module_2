using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Subjects
{
    public class SubjectsView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public int studenId { get; set; }
    }

}
