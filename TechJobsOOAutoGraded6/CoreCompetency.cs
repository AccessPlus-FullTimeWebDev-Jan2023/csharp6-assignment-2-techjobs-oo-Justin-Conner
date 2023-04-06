using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency: JobField
    {
        //fields

    

        // TODO: Task 2: Change the fields to auto-implemented properties.


        public CoreCompetency(string v) : base()
        {
            Value = v;
        }
        //custom methods
     /*   public override bool Equals(object obj)
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
        }*/
    }
}

