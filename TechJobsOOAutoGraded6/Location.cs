using System;
namespace TechJobsOOAutoGraded6
{
	public class Location: JobField
    {
        //fields
        //Constructors
        // TODO: Task 2: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.

        /*The second constructor should use the Location() constructor and set the value of the value field. This will create a new constructor that sets the value of the value field to an empty string, and another constructor that takes a value parameter and sets the value field to that value.  */


        public Location() : this("")
        {
        }
        public Location(string value) : base(value)
        {
            Value = value;
        }

 

        // Override Equals and GetHashCode methods to compare objects based on Value field.
        //See explination below for reasoning as to why the Equals method is not and should not be extended to the location class.
        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id &&
                   Value == location.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }

    }
}
/***A note specific to the extension of the common custom methods as it relates to jobfield.cs and location.cs the TestTask2/TestMethod 3 and why the public override bool Equals(object obj) method should not be extended in order to pass the test.**
*********************************************************************************************
The two methods are both implementations of the Equals method, but they are intended to be used for comparing different classes that have different properties.

The first method is used in the CoreCompetency class to compare CoreCompetency objects based only on their Id field. It checks whether the passed object is a CoreCompetency object and whether its Id field is equal to the Id field of the current CoreCompetency object.

The second method is used in the Location class to compare Location objects based on both their Id and Value fields. It checks whether the passed object is a Location object and whether its Id and Value fields are equal to the Id and Value fields of the current Location object, respectively.

The first method should not be extended to the second because they are implemented for different classes with different properties. While the first method checks for equality based on the Id field only, the second method checks for equality based on both the Id and Value fields. Extending the first method to the second would not provide the correct comparison behavior for Location objects, as it would ignore the Value field in the comparison.

Therefore, it is important to implement the Equals method appropriately for each class, considering the properties that need to be compared for equality. */

