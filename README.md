# ElvenNameGenerator
A simple C# code that generates random elvish names.

As a developer, whenever test data needed for people names I create a similiar solution to this one that generates some random names. Using some elven names made it pretty invariant culture and sort of fun. This time, I decided to go extra mile and put this in GitHub and publish the package as a NuGet package.

A quick google search for elven names revealed  the following [site](http://www.angelfire.com/rpg2/vortexshadow/names.html). Inspired by the method presented and using the prefixes and suffixes listed there, I implemented a simple class to randomly pick fullnames.

Feel free to submit feature requests, bug reports, issues and pull requests.

## Usage
### Generate a random name
``` c#
var generator = new ElvenNameGenerator();
var name = generator.GenerateName();
```

### Generate random 10 full names
``` c#
var generator = new ElvenNameGenerator();
var fullnames = generator.GenerateFullName().Take(10);
```

### Generate random 100 full names with fixed seed
```c#
// When you specify a seed, you'll get the same sequence with the same seed value 
var generator = new ElvenNameGenerator(42);
var fullnames = generator.GenerateFullName().Take(100);
```
