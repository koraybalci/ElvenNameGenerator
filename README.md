# ElvenNameGenerator
A simple C# code that generates random elvish names.

As a developer, whenever test data needed for people names, I create a similiar solution to this one that generates some random names. Using some elven names made it culture invariant and sort of fun.

A quick google search for elven names revealed [the following nice site](http://www.angelfire.com/rpg2/vortexshadow/names.html). Inspired by the method presented and using the prefixes and suffixes listed there, I implemented a simple class to randomly pick full elven names.

Feel free to submit [feature requests, bug reports, issues](https://github.com/koraybalci/ElvenNameGenerator/issues) and [pull requests](https://github.com/koraybalci/ElvenNameGenerator/pulls).

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

### Dependency injection
Use `IElvenNameGenerator` interface for DI in your own implementation.
``` c#
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElvenNameGenerator.Tests
{
    public class SampleClass
    {
        private readonly IElvenNameGenerator _elvenNameGenerator;

        public SampleClass(IElvenNameGenerator elvenNameGenerator)
        {
            _elvenNameGenerator = elvenNameGenerator;

            // Fix randomization to same sequence of names
            _elvenNameGenerator.Seed(42);
        }

        public IEnumerable<string> GenerateSameElvenNames(int count) =>
            _elvenNameGenerator.GenerateFullName().Take(count);

        public IEnumerable<string> GenerateDifferentElvenNames(int count)
        {
            _elvenNameGenerator.Seed(new Random().Next());
            return _elvenNameGenerator.GenerateFullName().Take(count);
        }
    }
}
```