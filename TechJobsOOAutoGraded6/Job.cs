using System;
using static System.Net.Mime.MediaTypeNames;

namespace TechJobsOOAutoGraded6
{
    public class Job
    {


        public int Id { get; }
        private static int nextId = 1;
        public object LocationJob;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        public string? Employerlocation { get; private set; }

        // TODO: Task 3: Add the two necessary constructors.
        /*This constructor initializes the Id field with a unique value by setting it to the current value of the nextId variable and then increments the nextId variable. This ensures that every Job object created using this constructor will have a unique identifier. */
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
        /*These are two overridden methods that are part of the Object class in C#, which the Job class inherits from. The Equals() method checks whether the current Job object is equal to another object, which is passed as an argument to the method. It does so by first checking whether the object is a Job object, using the is keyword. If it is a Job object, then it checks whether the Id of the current object is equal to the Id of the other Job object. If both Ids match, the method returns true, indicating that the two Job objects are equal. If they don't match, the method returns false.

        The GetHashCode() method returns an integer hash code that represents the current Job object. This method is used by hash-based collections such as dictionaries and hash sets to quickly find objects based on their hash codes. In this implementation, the hash code is calculated using the HashCode.Combine() method, which combines the hash codes of the Id field. */
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        //toString Pass test 1
        public override string ToString()
        {
            // Check if EmployerLocation is null or empty
            string locationValue = EmployerLocation == null || string.IsNullOrEmpty(EmployerLocation.Value) ? "Data not available" : EmployerLocation.Value;

            // Check if EmployerName is null or empty
            string employerValue = EmployerName == null || string.IsNullOrEmpty(EmployerName.Value) ? "Data not available" : EmployerName.Value;

            // Check if JobType is null or empty
            string jobTypeValue = JobType == null || string.IsNullOrEmpty(JobType.Value) ? "Data not available" : JobType.Value;

            // Check if JobCoreCompetency is null or empty
            string jobCoreCompetencyValue = JobCoreCompetency == null || string.IsNullOrEmpty(JobCoreCompetency.Value) ? "Data not available" : JobCoreCompetency.Value;

            // Format the string using string interpolation
            return $"\nID: {Id}\nName: {Name}\nEmployer: {employerValue}\nLocation: {locationValue}\nPosition Type: {jobTypeValue}\nCore Competency: {jobCoreCompetencyValue}\n";
        }

    }
}


