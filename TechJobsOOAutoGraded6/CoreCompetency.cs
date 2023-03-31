using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        // TODO: Task 2: Change the fields to auto-implemented properties.


        /*The default constructor CoreCompetency() sets the value of the id field to the value of nextId at the time of creation and then increments nextId. This constructor does not take any parameters. */

        /* To change the fields to auto-implemented properties, we need to remove the field declarations and replace them with property declarations. We also need to remove the corresponding initialization logic from the constructors since the properties will be initialized automatically. To initialize the value field for a new CoreCompetency object, we can modify the parameterized constructor to accept both id and value as parameters, and then pass the id value to the default constructor. */
        public CoreCompetency()
        {
           Id = nextId;
            nextId++;
        }
        /* The parameterized constructor CoreCompetency(string v) takes a string parameter v, which is used to set the value of the value field of the instance. It also calls the default constructor CoreCompetency() to initialize the id field with the next available value.*/
        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

