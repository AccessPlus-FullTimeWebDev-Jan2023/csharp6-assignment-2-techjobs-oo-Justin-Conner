*********************************************************************************************
HW2 Tech Jobs@* *@ This file is a breakdown of the files used in HW3 and how the code in the file works. Specific explainations of the requirements of the HW are included in the files that are to be ammended.

*********************************************************************************************
TestTasks2.cs
*********************************************************************************************

This code is a unit test for a C# program that contains classes named Location, CoreCompetency, and PositionType. The test cases are written using the MSTest testing framework.

The code is defining a class named TestTask2, which has several test methods that are marked with the [TestMethod] attribute. Each test method is responsible for testing a specific aspect of the Location, CoreCompetency, and PositionType classes.

The first test method named Test_Second_Location_Constructor_Exists checks if the Location class has a second constructor that takes a string argument. It uses reflection to get the constructors of the Location class and checks if any of them match the signature of the second constructor. If the second constructor is found, it sets the existsCheck variable to "Second Constructor". The test then compares the value of existsCheck to "Second Constructor" and fails if they are not equal.

The other test methods have similar names that indicate what they are testing. For example, Test_CoreCompetency_Accessor_SetUp checks if the CoreCompetency class has a getter for the Id property, and Test_PositionType_Equals_Method_SetUp tests the Equals method of the PositionType class. Each test method sets up the necessary objects, invokes the method being tested, and then uses assertions to check if the results are as expected.
@* *@
The code also includes some commented-out test methods that are not being run. These are likely other test cases that were written but are not currently being used.

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
@* *@
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
@* *@
The comment indicates that a second constructor needs to be added to the class. This constructor should use the default constructor of the class (i.e. the one with no parameters) and set the "Value" property of the instance to the value passed as a parameter to the new constructor. The purpose of this constructor is to allow the creation of a new instance of the class with a specified location value without having to call the default constructor and then set the value separately.

*********************************************************************************************
CoreCompentancy.cs            TODO: Task 2: Change the fields to auto-implemented properties.
*********************************************************************************************
This is a C# code defining a class named "CoreCompetency". It is similar to the "Employer" and "Location" classes in the previous examples, but with some differences.

**"fields" typically refer to the private variables that are declared within a class. They represent the internal state of an object and can be accessed and modified by methods within that class. In the given code, the fields of the CoreCompetency class are:** 

id: an integer that represents the unique identifier of a CoreCompetency object. This field is initialized by the constructor and is private, meaning it can only be accessed from within the class.
nextId: a static integer that keeps track of the next available id value for a new CoreCompetency object. This field is also private and can only be accessed within the class.
value: a string that represents the name or description of a CoreCompetency. This field is also private and can only be accessed within the class.

The class has three members: "id", "nextId", and "value". "id" and "value" are private fields, while "nextId" is a private static field.

The default constructor sets the value of "id" to the value of "nextId" at the time of creation, and then increments "nextId" so that the next instance of the class will have a unique "id" value.

The constructor with a single string parameter sets the "value" field of the instance to the value of the parameter and also calls the default constructor.

The "Equals" method overrides the default implementation of object equality and returns true if the object being compared is an instance of the "CoreCompetency" class with the same "id" value.

The "GetHashCode" method returns a hash code for the current instance based on its "id" property.

The "ToString" method overrides the default implementation of object string representation and returns the value of the "value" field.
@* *@
The comment indicates that the fields should be changed to auto-implemented properties. This means that instead of declaring the fields explicitly and then defining a separate property to get or set their values, the properties can be declared using shorthand syntax that combines the declaration and definition of the field and its accessor method into a single line of code. This would make the class definition shorter and more concise, but would not change its behavior.

*********************************************************************************************
PositionType.cs          TODO: Task 2: Add custom Equals(), 
                                             GetHashCode(), 
                                             and ToString() methods.
*********************************************************************************************
This is a class definition for PositionType. It has three members:
@* *@
The **Id property** is a read-only integer property that gets the unique identifier of the PositionType instance. It is initialized by the constructor with the value of the static nextId variable, which is then incremented for the next instance.
The **Value property** is a string property that gets or sets the value of the PositionType instance.
There are two constructors, a default constructor and a parameterized constructor that takes a string value. The **parameterized constructor** sets the Value property and calls the default constructor to initialize the Id property.
This code also has a TODO task to add custom Equals(), GetHashCode(), and ToString() methods, which can be used to customize the behavior of the PositionType class when used in certain operations such as comparing or hashing. These methods are not yet implemented

*********************************************************************************************
Job.cs
TODO: Task 3: Generate Equals() and GetHashCode() methods.
TODO: Task 3: Add the two necessary constructors.
TODO: Task 5: Generate custom ToString() method.
*********************************************************************************************
This is a C# code for a class named Job. It contains the following properties:

Id which is an integer and can only be read (not set).
Name which is a string and can be read and set.
EmployerName which is an object of type Employer and can be read and set.
EmployerLocation which is an object of type Location and can be read and set.
JobType which is an object of type PositionType and can be read and set.
JobCoreCompetency which is an object of type CoreCompetency and can be read and set.
The class also contains two constructors:

A default constructor that initializes the Id property with a unique value and increments nextId static field to prepare for the next instance to be created.
A parameterized constructor that sets all the properties of the class and calls the default constructor to initialize the Id property.
The Equals() method is overridden to compare two Job objects based on their Id property.

The **GetHashCode()** method is overridden to return a hash code based on the Id property.
@**@
A custom ToString() method is not yet implemented, but a note is left indicating that it needs to be created to be able to print a job to the console.

*********************************************************************************************
JobTests.cs
*********************************************************************************************
This code defines a unit test class for the Job class in the **TechJobsOOAutoGraded6** project. The JobTests class has four instance variables of the Job class that represent sample job objects. The **[TestClass]** attribute is applied to the **JobTests** class, which indicates that the class contains tests.

The **[Test]** attribute is applied to the **TestSettingJobId method**, which is a unit test method that checks whether the job IDs are correctly set for different job objects. In the **TestSettingJobId** method, four new Job objects are created, and their IDs are compared using the **Assert class** methods. The **Assert.IsFalse(job1Id == job2Id)** line checks whether the IDs of job1 and job2 are not equal. The **Assert.IsFalse(job3Id == job4Id)** line checks whether the IDs of job3 and job4 are not equal. The **Assert.AreEqual(job1Id + 1, job2Id)** line checks whether the ID of job2 is equal to the ID of job1 plus 1. The **Assert.AreEqual(job3Id + 1, job4Id)** line checks whether the ID of job4 is equal to the ID of job3 plus 1.
@**@
These tests ensure that the ID field of the Job class is set correctly and that each job object has a unique ID. If any of these tests fail, it indicates a problem with the Job class's constructor or ID field.

*********************************************************************************************
Tasks5
TODO: Task 5: Generate custom ToString() method.
TODO: Task 5: USE TDD TO BUILD THE TOSTRING() METHOD
*********************************************************************************************
Behavior 1: 
When passed a Job object, it should return a string that contains a blank line before and after the job information.

Create Test ToString()"Fail"-----------------------------------COMPLETED
Create Test 1 ToStringStartsAndEndsWithNewLine "Fail"----------COMPLETED
Code ToString() to Pass Test 1---------------------------------COMPLETED
*********************************************************************************************
Check for output after updating "ToString()"code below
*********************************************************************************************
Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
             Console.WriteLine(job.ToString());
*********************************************************************************************
Behavior 2: 
The string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line. There should be a new line between each job listing.

Create Test 2 TestToStringContainsCorrectLabelsAndData---------COMPLETED
Create Test ToString()"Pass"Test 2-----------------------------COMPLETED
*********************************************************************************************
Check for output after updating "ToString()"code below
*********************************************************************************************
// create a Job object with an empty employer location
Job job = new Job("Product tester", new Employer("ACME"), new Location(""), new PositionType("Quality control"), new CoreCompetency("Persistence"));
*********************************************************************************************
// get the string representation of the job
string jobString = job.ToString();

// print the jobString to the console
Console.WriteLine(jobString);
*********************************************************************************************
Behavior 3: 
If a field is empty, the method should add, “Data not available” after the label
@*@
Create Test 3 ToString()TestToStringHandlesEmptyField-------------------------------COMPLETED
Create Test ToString()"Pass"Test 3--------------------------------------------------COMPLETED

*********************************************************************************************
JobField.cs
TODO: Task 6 Create a new class called JobField 
*********************************************************************************************
common fields: **Id (int)**
			   **public string Value:**
			   **public string Value**
common constructors: N/A
custom methods: **GetHashCode():**
				**ToString():**
				**Equals(object obj):**
*********************************************************************************************
This code defines an abstract class JobField in the TechJobsOOAutoGraded6 namespace. The class has the following members:

**Id:** a read-only integer property that gets the unique identifier for each instance of the JobField class.
**nextId:** a private static integer field that is used to generate unique identifiers for each instance of the JobField class.
**Value:** a public string property that gets or sets the value of a JobField instance.
**JobField():** a parameterless constructor that initializes the Id property with the next available identifier and increments nextId to ensure that the next JobField instance has a unique identifier.
**JobField(string value):** a constructor that takes a string argument and initializes the Value property with the specified value, while also initializing Id with the next available identifier and incrementing nextId.
**Equals(object obj):** an override method that compares the current JobField instance with the specified object to determine whether they have the same Id.
**GetHashCode():** an override method that returns a hash code for the current JobField instance, based on its Id.
**ToString():** an override method that returns the string value of the Value property.
JobField is an abstract class, which means that it cannot be instantiated directly. Instead, 
it provides a base class for other classes to inherit from and define their own specific 
@*@
fields and behavior.

*********************************************************************************************
CoreCompentency.cs
TODO: Task 2: Change the fields to auto-implemented properties----------------------COMPLETED
TODO: Task 6 Create a new class called JobField-------------------------------------COMPLETED
*********************************************************************************************
fields: 
**private static int nextId** = 1;
**public int Id** { get; }
**public string Value** { get; set; }

constructors:
**public CoreCompetency()** - default constructor that initializes the Id field with the next available value.
**public CoreCompetency(string v) : this()** - parameterized constructor that sets the Value field and calls the default constructor to initialize the Id field.

custom methods:
**public override bool Equals(object obj)** - checks if the given object is equal to the current CoreCompetency object based on the Id field.
**public override int GetHashCode()** - returns a hash code value based on the Id field.
**public override string ToString()** - returns a string representation of the Value field.
*********************************************************************************************
This code defines a class named CoreCompetency in the TechJobsOOAutoGraded6 namespace. The class inherits from the abstract class JobField.

The class has one constructor that takes a string parameter and passes it to the base class constructor, which sets the Value property of the JobField object to the passed string value.
@*@
The class overrides three methods of the base class JobField: Equals, GetHashCode, and ToString. The Equals method returns true if the passed object is a CoreCompetency object and has the same Id as the current object. The GetHashCode method returns a hash code based on the Id property of the object. The ToString method returns the Value property of the object.

*********************************************************************************************
PositionType.cs
TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.-----------COMPLETED
TODO: Task 6 Create a new class called JobField-------------------------------------COMPLETED
*********************************************************************************************
Fields:

**public int Id** An automatically generated unique identifier for each PositionType object
**public string Value** The name or title of the position type

Constructors:

**public PositionType()**: The default constructor that sets the value of the Id field to the value of nextId at the time of creation and then increments nextId. This constructor does not take any parameters.
**public PositionType(string value)**: A parameterized constructor that takes a string parameter value, which is used to set the value of the Value field of the instance. It also calls the default constructor PositionType() to initialize the Id field with the next available value.

Custom Methods:

**public override string ToString()**: Overrides the ToString() method of the Object class and returns the value of the Value property of the PositionType object.
**public override bool Equals(object obj)**: Overrides the Equals() method of the Object class and compares the Id property of the current PositionType object with the Id property of the object passed as parameter. If both Id values are the same and the object passed as parameter is a PositionType object, it returns true; otherwise, it returns false.
**public override int GetHashCode()**: Overrides the GetHashCode() method of the Object class and returns a hash code based on the Id value of the PositionType object.
*********************************************************************************************
This code defines a class called **"PositionType"** which inherits from the **"JobField"** class. **"PositionType"** represents a type of position in a job listing.

The class has a constructor that takes a string value and passes it to the base constructor of **"JobField"**. This sets the **"Value"** property of the **"JobField"** base class to the given value, and assigns a unique integer ID to the **"Id"** property.

The class also overrides three methods from the **"JobField"** base class: **"ToString()"**, **"Equals()"**, and **"GetHashCode()"**. The **"ToString()"** method returns the value of the **"Value"** property as a string. The **"Equals()"** method compares the **"Id"** property of the current instance to that of another instance of **"PositionType"** to determine if they are equal. The **"GetHashCode()"** method returns a unique hash code for the instance based on its **"Id" property.

*********************************************************************************************
Location.cs
TODO: Task 2: Add a second constructor to this class that uses ---------------------COMPLETED
the Location() constructor and sets the value of the value field.
TODO: Task 6 Create a new class called JobField------------------------------------COMPLETED 
*********************************************************************************************
Fields:

**public int Id:** an integer field which represents the unique identifier for a Location object.
**private static int nextId:** a static integer field which keeps track of the next available identifier for a Location object.
**public string Value:** a string field which represents the name or description of a Location object.

Constructors:

**public Location():** a default constructor that initializes the Id field with the next available identifier and increments nextId.
**public Location(string value):** a parameterized constructor that calls the default constructor and sets the Value field with the provided value parameter.

Custom Methods:

**public override bool Equals(object obj):** an overridden method that checks if the passed object is a Location object and if so, compares its Id field to the Id field of the current object to determine if they are equal.
**public override int GetHashCode():** an overridden method that returns a hash code based on the value of the Id field.
**public override string ToString():** an overridden method that returns the value of the Value field as a string.
*********************************************************************************************
**A note specific to the extension of the common custom methods as it relates to jobfield.cs and location.cs the TestTask2/TestMethod 3 and why the public override bool Equals(object obj) method should not be extended in order to pass the test.**
*********************************************************************************************
The two methods are both implementations of the Equals method, but they are intended to be used for comparing different classes that have different properties.

The first method is used in the CoreCompetency class to compare CoreCompetency objects based only on their Id field. It checks whether the passed object is a CoreCompetency object and whether its Id field is equal to the Id field of the current CoreCompetency object.

The second method is used in the Location class to compare Location objects based on both their Id and Value fields. It checks whether the passed object is a Location object and whether its Id and Value fields are equal to the Id and Value fields of the current Location object, respectively.

The first method should not be extended to the second because they are implemented for different classes with different properties. While the first method checks for equality based on the Id field only, the second method checks for equality based on both the Id and Value fields. Extending the first method to the second would not provide the correct comparison behavior for Location objects, as it would ignore the Value field in the comparison.

Therefore, it is important to implement the Equals method appropriately for each class, considering the properties that need to be compared for equality.
*********************************************************************************************
This code defines a class called Location which is a subclass of **JobField**. The JobField class defines common properties and methods for all job fields.

The Location class has one constructor that takes a string value and sets it as the **Value** property inherited from the JobField class using the base constructor. It also overrides the **Equals, GetHashCode, and ToString** methods inherited from the **JobField** class.
@*@
The Equals method checks whether the passed object is a Location object and if it has the same Id value as the current object. The GetHashCode method generates a hash code based on the Id value. The **ToString** method returns the **Value** property as a string.

*********************************************************************************************
Employer.cs
TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.-----------COMPLETED
TODO: Task 6 Create a new class called JobField-------------------------------------COMPLETED
*********************************************************************************************
Fields:

**public int Id:** an integer field which represents the unique identifier for an Employer object.
**nextId:** a static integer field which keeps track of the next available identifier for an Employer object.
**public string Value:** a string field which represents the name or description of an Employer object.

Constructors:

**public Employer():** a default constructor that initializes the Id field with the next available identifier and increments nextId.
**public Employer(string value):** a parameterized constructor that calls the default constructor and sets the Value field with the provided value parameter.

Custom Methods:

**public override bool Equals(object obj):** an overridden method that checks if the passed object is an Employer object and if so, compares its Id field to the Id field of the current object to determine if they are equal.
**public override int GetHashCode():** an overridden method that returns a hash code based on the value of the Id field.
**public override string ToString():** an overridden method that returns the value of the Value field as a string.
*********************************************************************************************
This code defines a class named Employer that extends the abstract class JobField.

The Employer class has a constructor that takes a string parameter and calls the constructor of the JobField class, passing the value of the parameter as an argument.

The Employer class also overrides three methods from the JobField class: Equals(), GetHashCode(), and ToString(). The Equals() method compares two Employer objects to see if they have the same Id. The GetHashCode() method returns a hash code for the Employer object using its Id. The ToString() method returns the Value property of the Employer object.

This class is part of a larger project that is used to create job listings. Employer is one of the fields that can be used to describe a job.
*********************************************************************************************
TestTask.cs [TestMethod]  //2 breakdown
*********************************************************************************************
This test method is testing the RunProgram() method in the RunTechJobs class to ensure that the ToString() method of the Job class returns a string that starts and ends with a new line. This is a breakdown of what each part of the test method does:

TestMethod: 
This attribute indicates that this method is a unit test and should be run by the testing framework.
public void Test_TestToString_Starts_And_Ends_With_NewLine(): 
This is the name of the test method. It is a convention to name test methods in a way that describes what is being tested.
string text = System.IO.File.ReadAllText("C:\\Users\\ohmlo\\source\\repos\\csharp6-assignment-2-techjobs-oo-Justin-Conner\\TechJobsOO.Tests\\StartsAndEndsWithNewLine.txt").ToString();: 
This line reads the contents of a text file called "StartsAndEndsWithNewLine.txt" into a string variable called text. The file likely contains the expected output of the RunProgram() method.
var stringWriter = new StringWriter();: 
This line creates a new StringWriter object that will be used to capture the output of the RunProgram() method.
Console.SetOut(stringWriter);: 
This line redirects the output of the console to the StringWriter object created in the previous line.
var job = new RunTechJobs();: 
This line creates a new instance of the RunTechJobs class.
job.RunProgram();: 
This line calls the RunProgram() method of the RunTechJobs class, which creates several instances of the Job class and prints their information to the console using the ToString() method.
var output = stringWriter.ToString();: 
This line retrieves the captured output from the StringWriter object and stores it in a string variable called output.
Assert.AreEqual(text, output, "New Line issue");: 
This line compares the expected output stored in the text variable to the actual output stored in the output variable. If they are not equal, the test will fail with a message indicating a "New Line issue".





