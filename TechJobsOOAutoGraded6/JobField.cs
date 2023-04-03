using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TechJobsOOAutoGraded6
{
    public abstract class JobField
    {
        public int Id { get; } 
        private static int nextId = 1;
        public string Value { get; set; }
        //private static  string? value;

        public  JobField()
        {
            Id = nextId;//this.Value = value;
           nextId++;
        }
        public JobField(string value) : this()
        {
            Value = value;
        }

        /*public static int Increment()
         {
             //Id = nextId;
           return   nextId++;
         }*/

        //Common custom fields



        //Common custom methods
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
