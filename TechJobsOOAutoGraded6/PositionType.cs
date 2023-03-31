using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.

        /*I have added a ToString() method that returns the value of the Value property of the PositionType object.

I have also used the Visual Studio Code's "Generate" feature to generate the Equals() and GetHashCode() methods. These methods check if the object passed as parameter is a PositionType object and if it has the same Id value as the current object. If both conditions are true, the methods return true. GetHashCode() returns a hash code based on the Id value. 

 Visual Studio Code's "Generate" feature is a quick way to generate code for certain common programming tasks. To use it, you can right-click on the name of a class, property, or method in your code editor, and select "Quick Fix" or "Refactor" from the context menu that appears.

This will bring up a list of options for generating code, such as generating a constructor, a property, or an interface implementation. You can then select the option you want, and Visual Studio Code will generate the appropriate code for you.

Alternatively, you can use the keyboard shortcut "Ctrl+." on Windows or "Cmd+." on Mac to bring up the same list of options for generating code.*/
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

