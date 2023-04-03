using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType: JobField
    {
        //fields

        public PositionType(string value) : base()
        {
            Value = value;
        }

        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.


        
        //custom methods
        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }
             

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

