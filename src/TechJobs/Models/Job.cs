namespace TechJobs.Models
{
    public class Job
    {
        public int ID { get; set; }
        private static int nextId = 1;
        private static Data.JobData jobData;
        
        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }
        public CoreCompetency CoreCompetency { get; set; }
        public PositionType PositionType { get; set; }

        public Job()
        {
            ID = nextId;
            nextId++;
        }

        public Job(string name, int emp, int loc, int skill, int pos)
        {
            jobData = Data.JobData.GetInstance();
            ID = nextId;
            nextId++;
      
            Employer employer = jobData.Employers.Find(emp);
            Location location = jobData.Locations.Find(loc);
            CoreCompetency coreCompetency = jobData.CoreCompetencies.Find(skill);
            PositionType positionType = jobData.PositionTypes.Find(pos);
            this.Name = name;
            this.Employer = employer;
            this.Location = location;
            this.CoreCompetency = coreCompetency;
            this.PositionType = positionType;

        }
    }
}
