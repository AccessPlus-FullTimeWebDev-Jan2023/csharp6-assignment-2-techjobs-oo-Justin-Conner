

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

            Assert.IsFalse(job1Id == job2Id);
            Assert.IsFalse(job3Id == job4Id);
            Assert.AreEqual(job1Id + 1, job2Id);
            Assert.AreEqual(job3Id + 1, job4Id);
        }

    }


}


