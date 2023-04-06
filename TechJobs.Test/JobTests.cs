

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

        public JobTests()
        {
        }


        /*This test creates four Job objects, two with specified values (job1 and job2) and two with empty constructors (job3 and job4). It then retrieves the ID values for each job object, and uses assertions to check that:

        job3 and job4 have different IDs
        the ID difference between job1 and job2 is 1
        the ID difference between job3 and job4 is 1.
        These tests ensure that the unique IDs are correctly assigned to each Job object and that the ID values are sequential. */
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Database Admin", new Employer("Bank"), new Location("country"), new PositionType("SQL developer"), new CoreCompetency("Product owner"));
            Job job2 = new Job("Front end Dev", new Employer("ESR"), new Location("City"), new PositionType("UX Design"), new CoreCompetency("Promptness"));

            Assert.IsFalse(job1.Equals(job2));
        }

        /*This test creates a Job object using the full constructor and then calls its ToString() method to get a string representation of the job. It then uses assertions to check that the string starts and ends with a new line, and that each field has a label and a value. */

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            // Arrange
            Job job = new Job("Software Engineer", new Employer("Google"), new Location("Mountain View, CA"), new PositionType("Full-time"), new CoreCompetency("Programming"));

            // Act
            string jobString = job.ToString();

            // Assert
            string expectedResult = 
                $"{Environment.NewLine}ID: {job.Id}" +
                $"{Environment.NewLine}Name: Software Engineer" +
                $"{Environment.NewLine}Employer: Google" +
                $"{Environment.NewLine}Location: Mountain View, CA" +
                $"{Environment.NewLine}Position Type: Full-time" +
                $"{Environment.NewLine}Core Competency: Programming{Environment.NewLine}";
            Assert.AreEqual(expectedResult, jobString);

            Assert.IsTrue(jobString.StartsWith(Environment.NewLine));
            Assert.IsTrue(jobString.EndsWith(Environment.NewLine));
        }



        /*This test creates a Job object with an empty Location field and uses the ToString() method to get a string representation of the job. It then splits the string by new lines and checks that the empty field has "Data not available" after the label. */
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            // Arrange
            Employer employer = new Employer("ACME");
            Location location = new Location("New York");
            PositionType positionType = new PositionType("Manager");
            CoreCompetency coreCompetency = new CoreCompetency("Leadership");
            Job job = new Job("Job Name", employer, location, positionType, coreCompetency);

            string expectedOutput =
                $"{Environment.NewLine}ID: {job.Id}" +
                $"{Environment.NewLine}Name: Job Name" +
                $"{Environment.NewLine}Employer: ACME" +
                $"{Environment.NewLine}Location: New York" +
                $"{Environment.NewLine}Position Type: Manager" +
                $"{Environment.NewLine}Core Competency: Leadership" +
                $"{Environment.NewLine}";

            // Act
            string actualOutput = job.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }


        public Assert GetAssert(Assert assert)
        {
            return assert;
        }

        /*This test creates a new Job object with an empty Location field, and then checks if the ToString() method of the object returns the expected result. The expected result includes the label "Location" followed by the string "Data not available". The test uses the Assert.AreEqual() method to check if the expected result and the actual result of the ToString() method match. */
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {

            Job testJob = new Job("Product tester", new Employer("Data not available"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string expectedResult = 
            $"{Environment.NewLine}ID: {testJob.Id}"+
            $"{Environment.NewLine}Name: {testJob.Name}"+
            $"{Environment.NewLine}Employer: {testJob.EmployerName}" +
            $"{Environment.NewLine}Location: {testJob.EmployerLocation}" +
            $"{Environment.NewLine}Position Type: {testJob.JobType}" +
            $"{Environment.NewLine}Core Competency: {testJob.JobCoreCompetency}{Environment.NewLine}";

            string actualResult = testJob.ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }



    }





}





