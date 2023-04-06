using System;
namespace TechJobsOOAutoGraded6
{
	public class Employer: JobField
	{


        public Employer(string value) : base()
        {
            Value = value;
        }
        //custom methods
        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

