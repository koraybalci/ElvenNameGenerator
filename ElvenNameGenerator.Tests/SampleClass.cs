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
            _elvenNameGenerator.GenerateFullNames().Take(count);

        public IEnumerable<string> GenerateDifferentElvenNames(int count)
        {
            _elvenNameGenerator.Seed(new Random().Next());
            return _elvenNameGenerator.GenerateFullNames().Take(count);
        }
    }
}
