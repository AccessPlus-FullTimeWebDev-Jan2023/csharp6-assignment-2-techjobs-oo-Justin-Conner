*********************************************************************************************
HW2 Tech Jobs
*********************************************************************************************
Employer.cs
*********************************************************************************************
This is a C# code defining a class named "Employer". This class has three members: "Id", "nextId", and "Value". Here's what each member does:

"Id" is a read-only integer property that is initialized when a new instance of the class is created. Its value is set to the value of "nextId" at the time of creation. "nextId" is then incremented by 1 so that the next instance of the class will have a unique "Id" value.

"nextId" is a static integer field that is used to keep track of the next available "Id" value.

"Value" is a public string property that can be set and retrieved.

The class has three methods:

The default constructor sets the "Id" property of the instance to the current value of "nextId" and then increments "nextId" so that the next instance will have a unique "Id" value.

The constructor with a single string parameter sets the "Value" property of the instance to the value of the parameter and also calls the default constructor.

The "Equals" method overrides the default implementation of object equality and returns true if the object being compared is an instance of the "Employer" class with the same "Id" value.

The "GetHashCode" method returns a hash code for the current instance based on its "Id" property.

The "ToString" method overrides the default implementation of object string representation and returns the value of the "Value" property.

Overall, this class provides a way to represent an employer entity with an automatically generated unique identifier.
*********************************************************************************************
Locations.cs 
TODO: Task 2: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.
*********************************************************************************************
This is a C# code defining a class named "Location". It is very similar to the "Employer" class in the previous example. It has three members: "Id", "nextId", and "Value".

"Id" is a read-only integer property that is initialized when a new instance of the class is created. Its value is set to the value of "nextId" at the time of creation. "nextId" is then incremented by 1 so that the next instance of the class will have a unique "Id" value.

"nextId" is a static integer field that is used to keep track of the next available "Id" value.

"Value" is a public string property that can be set and retrieved.

The class has four methods:

The default constructor sets the "Id" property of the instance to the current value of "nextId" and then increments "nextId" so that the next instance will have a unique "Id" value.

The constructor with a single string parameter sets the "Value" property of the instance to the value of the parameter and also calls the default constructor.

The "Equals" method overrides the default implementation of object equality and returns true if the object being compared is an instance of the "Location" class with the same "Id" value.

The "GetHashCode" method returns a hash code for the current instance based on its "Id" property.

The "ToString" method overrides the default implementation of object string representation and returns the value of the "Value" property.

The comment indicates that a second constructor needs to be added to the class. This constructor should use the default constructor of the class (i.e. the one with no parameters) and set the "Value" property of the instance to the value passed as a parameter to the new constructor. The purpose of this constructor is to allow the creation of a new instance of the class with a specified location value without having to call the default constructor and then set the value separately.
*********************************************************************************************
CoreCompentancy.cs            TODO: Task 2: Change the fields to auto-implemented properties.
*********************************************************************************************
This is a C# code defining a class named "CoreCompetency". It is similar to the "Employer" and "Location" classes in the previous examples, but with some differences.
@*
**"fields" typically refer to the private variables that are declared within a class. They represent the internal state of an object and can be accessed and modified by methods within that class. In the given code, the fields of the CoreCompetency class are:** *@

id: an integer that represents the unique identifier of a CoreCompetency object. This field is initialized by the constructor and is private, meaning it can only be accessed from within the class.
nextId: a static integer that keeps track of the next available id value for a new CoreCompetency object. This field is also private and can only be accessed within the class.
value: a string that represents the name or description of a CoreCompetency. This field is also private and can only be accessed within the class.

The class has three members: "id", "nextId", and "value". "id" and "value" are private fields, while "nextId" is a private static field.

The default constructor sets the value of "id" to the value of "nextId" at the time of creation, and then increments "nextId" so that the next instance of the class will have a unique "id" value.

The constructor with a single string parameter sets the "value" field of the instance to the value of the parameter and also calls the default constructor.

The "Equals" method overrides the default implementation of object equality and returns true if the object being compared is an instance of the "CoreCompetency" class with the same "id" value.

The "GetHashCode" method returns a hash code for the current instance based on its "id" property.

The "ToString" method overrides the default implementation of object string representation and returns the value of the "value" field.

The comment indicates that the fields should be changed to auto-implemented properties. This means that instead of declaring the fields explicitly and then defining a separate property to get or set their values, the properties can be declared using shorthand syntax that combines the declaration and definition of the field and its accessor method into a single line of code. This would make the class definition shorter and more concise, but would not change its behavior.
*********************************************************************************************
PositionType.cs          TODO: Task 2: Add custom Equals(), 
                                             GetHashCode(), 
                                             and ToString() methods.
*********************************************************************************************
This is a class definition for PositionType. It has three members:

The **Id property** is a read-only integer property that gets the unique identifier of the PositionType instance. It is initialized by the constructor with the value of the static nextId variable, which is then incremented for the next instance.
The **Value property** is a string property that gets or sets the value of the PositionType instance.
There are two constructors, a default constructor and a parameterized constructor that takes a string value. The **parameterized constructor** sets the Value property and calls the default constructor to initialize the Id property.
This code also has a TODO task to add custom Equals(), GetHashCode(), and ToString() methods, which can be used to customize the behavior of the PositionType class when used in certain operations such as comparing or hashing. These methods are not yet implemented