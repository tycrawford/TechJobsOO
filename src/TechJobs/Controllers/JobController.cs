using Microsoft.AspNetCore.Mvc;
using TechJobs.Data;
using TechJobs.ViewModels;
using System;

namespace TechJobs.Controllers
{
    public class JobController : Controller
    {

        // Our reference to the data store
        private static JobData jobData;

        static JobController()
        {
            jobData = JobData.GetInstance();
        }

        // The detail display for a given Job at URLs like /Job?id=17
        public IActionResult Index(int id)
        {
            TechJobs.Models.Job someJob = jobData.Find(id);
            // TODO #1 - get the Job with the given ID and pass it into the view
            SingleJobViewModel jobFieldsViewMode = new SingleJobViewModel();
            jobFieldsViewMode.bob = jobData.Find(id);
            return View(jobFieldsViewMode);
        }

        public IActionResult New()
        {
            NewJobViewModel newJobViewModel = new NewJobViewModel();
            return View(newJobViewModel);
        }

        [HttpPost]
        public IActionResult New(NewJobViewModel newJobViewModel)
        {
            if (!(String.IsNullOrWhiteSpace(newJobViewModel.Name)))
            {
                
                TechJobs.Models.Job job = new TechJobs.Models.Job(newJobViewModel.Name, newJobViewModel.EmployerID, newJobViewModel.LocationID, newJobViewModel.CoreCompetencyID, newJobViewModel.PositionTypeID);

                int workingId = job.ID;
                jobData.Jobs.Add(job);
                return Redirect("/job?id=" + workingId.ToString());
            }
            
            // TODO #6 - Validate the ViewModel and if valid, create a 
            // new Job and add it to the JobData data store. Then
            // redirect to the Job detail (Index) action/view for the new Job.

            return View(newJobViewModel);
        }
    }
}
