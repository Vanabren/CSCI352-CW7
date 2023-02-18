# CW7 Vance Brender-A-Brandis #

## Description ##
- My implementation of the CW7.dia UML design, which focus on the Decorator structural design pattern.

## Project Details ##
- The project contains a widget interface (IWidget) from which a TextField concrete class is created from, as well as an abstract Decorator class.
- The Decorator class has three children: a BorderDecorator concrete class, a PictureDecorator concrete class, and a ScrollDecorator concrete class.
- An object of TextField type is created in main along with one of each child class derived from the Decorator class.
- Each child's constructor is argued with the TextField object.
- Each object's draw() method is called one after the other within main.
