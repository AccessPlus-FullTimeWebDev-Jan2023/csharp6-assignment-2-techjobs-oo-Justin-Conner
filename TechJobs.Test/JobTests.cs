

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing objects
        Job job1 = new Job("Database Admin", new Employer("Bank"), new Location("country"), new PositionType("SQL developer"), new CoreCompetency("Product owner"));

        Job job2 = new Job("Front end Dev", new Employer("ESR"), new Location("City"), new PositionType("UX Design"), new CoreCompetency("Promptness"));

        Job job3 = new Job("DevOps", new Employer("Sony"), new Location("Mountain"), new PositionType("Deployment"), new CoreCompetency("Friendliness"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

      
/*This test creates four Job objects, two with specified values (job1 and job2) and two with empty constructors (job3 and job4). It then retrieves the ID values for each job object, and uses assertions to check that:

job3 and job4 have different IDs
the ID difference between job1 and job2 is 1
the ID difference between job3 and job4 is 1.
These tests ensure that the unique IDs are correctly assigned to each Job object and that the ID values are sequential. */
        [Test]
        public void TestSettingJobId()
        {
            Job job1 = new Job("Database Admin", new Employer("Bank"), new Location("country"), new PositionType("SQL developer"), new CoreCompetency("Product owner"));
            Job job2 = new Job("Front end Dev", new Employer("ESR"), new Location("City"), new PositionType("UX Design"), new CoreCompetency("Promptness"));

            Job job3 = new Job();
            Job job4 = new Job();

            int job1Id = job1.Id;
            int job2Id = job2.Id;
            int job3Id = job3.Id;
            int job4Id = job4.Id;

            Assert.IsFalse(job3Id == job4Id);
            Assert.IsTrue(job2Id - job1Id == 1);
            Assert.IsTrue(job4Id - job3Id == 1);
        }
        /*This test creates a Job object with the specified properties using the full constructor, and then uses Assert statements to check that each property has been correctly assigned. If any of the Assert statements fail, it indicates that the Job object was not constructed correctly. */
        [Test]
        public void TestJobConstructorSetsAllFields()
        {
            // create a Job object with the full constructor
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            // use Assert statements to test that the constructor correctly assigns the value of each field
            Assert.AreEqual("Product tester", job.Name);
            Assert.AreEqual("ACME", job.EmployerName.Value);
            Assert.AreEqual("Desert", job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job.JobType.Value);
            Assert.AreEqual("Persistence", job.JobCoreCompetency.Value);
        }
        /*In this test, we create two Job objects job1 and job2, and we use the Equals() method to test whether they are equal. Since they have different values for all of their fields, we expect Equals() to return false, and we use the Assert.IsFalse() method to verify that this is the case. */
        [Test]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Database Admin", new Employer("Bank"), new Location("country"), new PositionType("SQL developer"), new CoreCompetency("Product owner"));
            Job job2 = new Job("Front end Dev", new Employer("ESR"), new Location("City"), new PositionType("UX Design"), new CoreCompetency("Promptness"));

            Assert.IsFalse(job1.Equals(job2));
        }



    }


}


