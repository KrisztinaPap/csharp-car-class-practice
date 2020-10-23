# C# OOP Practice - Car Class

## Deadline: October 23, 2020, 9am
## Last edited: October 23, 2020

## Author: Krisztina Pap

## Instructions
### Introduction
This practice is designed to help you familiarize yourself with object reference properties, access modifiers and encapsulation.

### Requirements
#### “Car” Class created:
##### Properties:
- “Make” (Chevrolet, Nissan, Toyota)
- “Model” (Camry, Corolla, Cruze)
- “Color” (Red, Green, Blue, Black)
- “MaximumOccupancy” (Number of Seats)
- “FuelEfficiency” (Number of KM per Litre, can have decimals)
- “Odometer” - object reference
- “FuelTank” - object reference.
##### Methods:
- Drive() and Drive(km) - call BurnFuel() and Increment() on the fuel tank and odometer, respectively, according to fuel efficiency.
- A ToString() override that will output the format “A Blue Chevy Cruze with 060050KM on the odometer, that has enough fuel to travel 65KM.”
- Both a default and greedy constructor (initialize object references as a new instance).
#### “Odometer” Class created:
##### Properties:
- “Counter” with a getter and a private setter
- Perform reset validation in the counter’s setter.
- If the new value would go over 999999, reset it to 0 and apply the excess (for example, 999980 + 40 = 20). 
##### Methods:
- Increment(amount)
- Add “amount” to the “Counter” property.
- Default constructor that initializes the counter at 0.

#### “FuelTank” Class created:
##### Properties:
- “Capacity”, a decimal value in litres, with a private setter
- “Level”, a decimal value in litres, with a private setter
- Throw an exception if a value below 0 is incoming.
- Clamp the value at the capacity.
##### Methods:
- BurnFuel(litres)
- Subtract “litres” from the “Level” property.
- Fill(litres)
- Add “litres” to the “Level” property.
- Write a default constructor that initializes “Capacity” at 50 and “Level” at 50.

### Challenges
- Create a “Motor” class and move “FuelEfficiency” into that class, add an object reference thereto in “Car”.
- Create a “Seat” object with a boolean for whether it is occupied, and change “MaximumOccupancy” to an array of “Seat”s.
- Continue to accept a maximum occupancy integer in the constructor of the car, and define the array size based thereon.
- Ensure that the first seat is occupied prior to driving.



## Trello Project Board:
https://trello.com/b/NGUA7LHR/c-review-oop-practice-car-class

## References/Citations
- Aaron Barthel helped me figure out how to properly display the object values
- [stackoverflow: C# convert int to string with padding zeros?](https://stackoverflow.com/questions/4325267/c-sharp-convert-int-to-string-with-padding-zeros#4325289)