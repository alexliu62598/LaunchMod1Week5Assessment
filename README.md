# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)
1. What would happen if you try to use a variable that is not in scope?

If we try to use a variable that is not in scope, we will be met by an error that explains that the variable in question "does not exist in the current context". 

2. Describe the three As of a test:  
A -   Arrange - In this step, we set things up so that things are ready to be tested. For example, we may create a new instantiation of a class so that we can invoke a method on it in the next step.
A -   Act - This step involves actually invoking the method that we are trying to test.
A -   Assert - This step involves using Assert.Equal() to test if the result of invoking the method yields the expected result. Assert.Equal() takes in two parameters: the expected result and the actual result. 

3. What is the difference between `public` and `private` access modifiers?

The 'public' access modifier allows the code in question to be accessed outside of the class that contains it. The 'private' access modifier restricts the use of the code in question to the class that contains it. For example, if we declare a property of a class using the 'private' access modifier and then attempt to reassign that property in our program, we will be met by an error that refers to that property as 'inaccessible'.

4. A method should:  (**Select all that apply**) <br/>
(A) Make changes to an object  
(B) Return some information about an object  
(C) Make changes to an object and return information about the object.  
(D) None of the Above.  

A, B

5. How did you determine what to answer for the question above?

I determined that A and B are the correct answers by referring to the concept of query and command methods. A query method returns information about an object, while a command method makes changes to the program itself. However, a method should typically refrain from handling more than one responsibility at a time, which means that option C is incorrect.

## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
