# calculator421 Tutorial on Encapsulation, Abstraction, Inheritance, Polymorphism

The code for this example is a simple calculator code. Nothing fancy, but has all the functions a basic calculator should have.
What this code also does besides show off its calculating prowess is display the use of four object oriented principles. 
Encapsulation, Abstraction, Inheritance, and Polymorphism.

We will first start with Encapsulation. In the example of the Calculator, Encapsualtion is expressed with each of the mathmatical functions.
Each function is separated into a file of its with no influince from any outside code. The function is called when it is needed, cruntches
numbers that are sent to it in the most logical way it sees fit, and then returns it. No program can tell this function WHAT to do.

Abstraction is when you have something complicated but you do not need to know how it works in order to use it. In the example code of the calculator
abstration is shown by giving the user six operations. The user enters them however they wish but and does not have to worry about how the 
answer is generated but knows that it WILL be gnerated and correct. The example code shows that when an addition gets performormed the code for
addition is called and then determains if the numbers are integers, decimals, a list, or a combination of either. The answer is then calculated and 
returned to the user. The user does not know that the computer did extra work or how it did it but they were able to produce and answer.

Inheritance is whne code can use anything of the code before it and add more onto it without changing the code its using. Using the basic
calculator as an example. The calcualtor file inherits all of the capabilities of the 6 functions but is able to manipulate the answer it recieves depending
on what the user was looking for. 

Finally we have Polymorphism. Polymorphism allows us to have multiple functions or classes that get chosen based on what is needed automatically.
Using our calculator code for example. When the add function is used, numbers are passed to the function. The program will then determain
if the numbers are decimals or intergers. Depending on that answer changes whether it will use the interger add or the decimal add.
This also allows the program to return the same data type that it started with.
