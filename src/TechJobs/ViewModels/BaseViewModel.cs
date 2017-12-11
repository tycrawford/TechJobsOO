using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {// TODO #7.2 - Extract members common to SearchJobsViewModel
        // to BaseViewModel

        // The current column
        public Models.JobFieldType Column { get; set; }



        // All columns, for display
        public List<Models.JobFieldType> Columns { get; set; }

        // View title
        public string Title { get; set; } = "";


    }
}
