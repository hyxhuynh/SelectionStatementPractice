# Exercise 1: Favorite Number Guessing Game
### Task:
Allow user to attempt to guess your favorite number.

### Initialize Your Favorite Number:
### Option 1 - Random Number:
The code snippet below uses the Random class to generate a random integer between 1 and 1000. 

The `Random().Next(minValue, maxValue)` method generates a random integer where `minValue` is inclusive, and `maxValue` is exclusive.

Here, it's set to generate a number between 1 and 1000.
```
Random r = new Random();
int favNumber = r.Next(1, 1000); // Generates a random number between 1 and 999
```

### Option 2 - Specific Number:
Alternatively, you can directly assign your favorite number to the variable `favNumber` by replacing the random number generation line with a specific number. For example, if your favorite number is 7:
```
int favNumber = 7; // Directly setting the favorite number to 7
```
Capture User Guess:
Prompt the user to guess your favorite number and read their input.
```
Console.WriteLine("Guess my favorite number between 1 and 1000:");
var userInput = int.Parse(Console.ReadLine());
```
Implement Feedback Logic:
Use an if-else statement to provide feedback based on the user's guess:

* If the guess is too low, print "Too low".
* If the guess is too high, print "Too high".
* If the guess is correct, print a congratulatory message, e.g., "You guessed it!!!".

### Save and Push Your Changes:

After completing the program, save your changes, commit, and push them back to GitHub.

### Note:
The choice between a random favorite number and a specific favorite number allows for different game experiences. Using a random number makes the game unpredictable, while a specific number can be used for a more personalized experience.


# Exercise 2: Favorite School Subject
### Task:
Create functionality that responds to the user's favorite school subject. 

### Receive User Input:

Prompt the user to input their favorite school subject. Store their response in a variable.
```
Console.WriteLine("What is your favorite school subject?");
string favoriteSubject = Console.ReadLine();
```

Write a switch statement using the variable that holds the user's favorite subject.  (You may need to look up the syntax for a switch case)

Create five cases for subjects (e.g., Math, Science, etc.) with unique console messages like "Math is cool because it's all about solving problems!"

Add a default case to handle unexpected subjects with a message such as "Interesting choice! What do you like about it?"


### Push your work to GitHub:

Remember to save your work, commit the changes, and push them back to GitHub, whether you chose to work in the original repository or a new one.



# Additional Practice:
Try this Codewars problem for more switch statement exercise:

[Switch/Case Bartender Kata](https://www.codewars.com/kata/568dc014440f03b13900001d/train/csharp)
