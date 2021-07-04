using System.Collections.Generic;

namespace ElvenNameGenerator
{
    public interface IElvenNameGenerator
    {
        /// <summary>
        /// Generates a single elven name as one word.
        /// </summary>
        /// <returns>Elven name</returns>
        string GenerateName();

        /// <summary>
        /// When you need a full elven name with a space in between, use this method.
        /// </summary>
        /// <returns>An elven full name with first and last name.</returns>
        string GenerateFullName();

        /// <summary>
        /// Use .Take() to specify number of elven full names you want to generate.
        /// </summary>
        /// <returns>Enumerable of elven full names.</returns>
        IEnumerable<string> GenerateFullNames();

        /// <summary>
        /// Seeds randomization so that with the same seed, same name sequences are generated.
        /// </summary>
        /// <param name="seed">A seed value that will be used in randomization.</param>
        void Seed(int seed);
    }
}