

/* 

	Assignment 1: Classes and Objects

	Task:

	1.	Create a class Student with properties for Name, Age, and Grade.
	2.	Implement a constructor to initialize these properties.
	3.	Create an object of the Student class and print out its details.
	
*/

/* ********************************************************************************* */

/* 

	Assignment 2: Constructors

	Task:

	1.	Create a class Course with properties for CourseCode, CourseName, and Instructor.
	2.	Implement a parameterless constructor that sets default values for these properties.
	3.	Implement a parameterized constructor to initialize these properties with given values.
	4.	Create objects of the Course class using both constructors and display their details.
	
*/


/* ********************************************************************************* */


/* 

	Assignment 3: Static Variable, Classes and Methods

	Task:

	1.	Create a static class CourseManager with a static list (courses) to store courses.
	2.	Implement static methods to add courses 
		(AddCourse()), retrieve courses (GetCourses()), and check course availability (IsCourseAvailable()).
	3.	Use the CourseManager class in the main program to demonstrate adding courses, retrieving them, and checking availability.
	
*/


/* ********************************************************************************* */

/* 

	Assignment 4: Abstract Methods and Abstract Classes

	Task:

	1.	Create an abstract class Course with abstract methods CalculateTotalHours() and PrintCourseDetails().
	2.	Define properties such as CourseCode, CourseName, Instructor, and DurationHours.
	3.	Implement two derived classes ProgrammingCourse and MathCourse inheriting from Course with overridden methods and properties.
	4.	Demonstrate polymorphism by calling CalculateTotalHours() and PrintCourseDetails() on objects of both derived classes.
	
*/

/* ********************************************************************************* */

/* 

	Assignment 5: Implement Properties for Courses

	Task:

	1.	Modify the Course class to encapsulate the DurationHours property with validation to ensure its non-negative.
	2.	Implement properties for CourseCode, CourseName, and Instructor with standard property syntax.
	3.	Use the Course class in the main program to demonstrate setting and getting course properties and handling validation errors.
	
*/

/* ********************************************************************************* */

/*

	Assignment 6: Implementing Interfaces and Abstract Classes in C#

	Task:
	
	Define an Interface and Abstract Class:

	Create an interface ICourse with methods CalculateTotalHours() and PrintCourseDetails().
	Create an abstract class Course that implements the ICourse interface.
	The Course class should have properties: CourseCode, CourseName, Instructor, and DurationHours.
	Ensure DurationHours property includes validation to ensure the value is non-negative.
	
	Implement Derived Classes:

	Create two derived classes: ProgrammingCourse and MathCourse, inheriting from the Course class.
	Each derived class should have additional properties specific to the course type (ProgrammingLanguage for ProgrammingCourse and MathTopic for MathCourse).
	Override the CalculateTotalHours() and PrintCourseDetails() methods in each derived class.
	
	Demonstrate Polymorphism:

	In the main program, create instances of ProgrammingCourse and MathCourse through the ICourse interface.
	Demonstrate setting and getting properties for each course type.
	Handle validation errors for the DurationHours property.

*/

/* ********************************************************************************* */

/*

	Assignment 7: Basic Exception Handling in Student Management System

	Task:

	Create a Student Class:

	Define a Student class with properties: StudentID, Name, Age, and Grade.
	Implement a constructor to initialize these properties.
	Implement Exception Handling:

	Add validation in the Student class:

	Age should be between 0 and 150.
	Grade should be between 0 and 100.
	Use appropriate exceptions (e.g., ArgumentOutOfRangeException) to handle invalid values.

	Demonstrate Exception Handling:

	Write a main program that creates instances of Student and demonstrates handling of invalid inputs.

*/

/* ********************************************************************************* */

/*

	Assignment 8: Custom Exception Handling in Student Management System

	Task:

	Define Custom Exception:

	Create a custom exception class named InvalidStudentDataException for handling invalid student data.
	Enhance the Student Class:

	Modify the Student class to use the InvalidStudentDataException for validation errors.

	Exception Handling:

	Implement exception handling in the main program to catch and handle the custom exceptions.

*/

/* ********************************************************************************* */

/*

	Assignment 9: Exception Handling in Student Enrollment System

	Task:

	Create a Class for Student Enrollment:

	Define a StudentEnrollment class with methods to enroll students in courses.
	Implement validation for course capacity and student eligibility.

	Exception Handling:

	Define custom exceptions:

	CourseFullException: Thrown when trying to enroll in a full course.
	StudentNotEligibleException: Thrown when a student does not meet course prerequisites.

	Implementation:

	Implement methods for enrolling students.
	Handle exceptions in the main program and provide appropriate messages.

*/

/* ********************************************************************************* */

/*

	Assignment 10: Implementing Indexers in a Student Management System

	Task:

	1.	Create a Student Class:
	o	Define a Student class with properties: StudentID, Name, Age, and Grade.

	2.	Create a StudentCollection Class:
	o	Define a StudentCollection class to manage a collection of Student objects.
	o	Implement an indexer in the StudentCollection class to provide access to Student objects using an index.

	3.	Enhance the StudentCollection Class:

	o	Add methods to add, remove, and retrieve students.
	o	Implement validation to handle cases where an index is out of bounds.

	4.	Demonstrate Indexers:

	o	Write a main program to demonstrate adding students to the collection, accessing them using the indexer, and handling out-of-bounds access.

*/

/* ********************************************************************************* */

/*

	Assignment 11: Working with Collections in a Student Management System

	Task:

	1.	Create a Student Class:

	o	Define a Student class with properties: StudentID, Name, Age, and Grade.

	2.	Implement Different Collections:

	o	Create classes to manage students using different collection types: List, Dictionary, and SortedList.

	3.	Perform CRUD Operations:

	o	Implement methods to add, retrieve, update, and delete students in each collection type.

	4.	Demonstrate Collection Usage:

	o	Write a main program to demonstrate adding, retrieving, updating, and deleting students in each collection type.
	o	Handle potential exceptions such as adding duplicate keys in a dictionary or updating non-existing students.

*/


/* ********************************************************************************* */

/*

	Assignment 12: File Handling in a Student Management System

	Task:

	1.	Create a Student Class:

	o	Define a Student class with properties: StudentID, Name, Age, and Grade.

	2.	Implement File Handling Methods:

	o	Create a StudentFileHandler class to manage file operations.
	o	Implement methods to save students to a file and load students from a file.

	3.	Perform File Operations:

	o	Write a main program to demonstrate saving student data to a file and retrieving it from the file.
	o	Handle potential exceptions such as file not found or data format issues.

*/
