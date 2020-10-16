3. current responsibility of the ControlUnit.PollSensors() method is to create new sensors.

5. The responsibility now of the PollSensors() is to output the results of polling a set of sensors.

6. It breaks mainly the Interface Segregation Principle. According to this principle there should not be "fat" interfaces, basically methods in the interface that the client code does not need.
This also breaks Liskov Substitution Principle, because some methods that were implemented in a class are not in the interface anymore, 
there is a method that a class does not have from the interface it is implementing.

10. By doing this we are maintaining the Single responsibility principle, because each type of sensor will have it's own logic, and a specific responsibility. We are also maintaining the Open/Close principle because we are extending the functionality, without breaking the existing functions.