﻿using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class JobFieldsViewModel : BaseViewModel
    {
        // All fields in the given column
        public IEnumerable<Models.JobField> Fields { get; set; }
        public JobFieldsViewModel()
        {
            // Populate the list of all columns

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }


        }
    }
}
