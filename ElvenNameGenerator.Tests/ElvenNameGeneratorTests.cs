using System.Linq;
using Xunit;

namespace ElvenNameGenerator.Tests
{
	public class ElvenNameGeneratorTests
    {
		private readonly ElvenNameGenerator _generator;

		public ElvenNameGeneratorTests()
		{
			_generator = new ElvenNameGenerator();
		}

		[Theory]
		[InlineData(10)]
		[InlineData(20)]
		[InlineData(100)]
		public void GenerateFullName_ShouldGenerate_ExpectedNumberofNames(int count)
        {
			var names = _generator.GenerateFullName().Take(count);

			Assert.Equal(count, names.Count());
        }

		[Fact]
		public void GenerateFullName_ShouldGenerateSameName_WithSameSeed()
		{
			var generator1 = new ElvenNameGenerator(42);
			var generator2 = new ElvenNameGenerator(42);

			Assert.Equal(generator1.GenerateFullName().Take(1).First(), 
				generator2.GenerateFullName().Take(1).First());
		}

		[Fact]
		public void GenerateFullName_ShouldNotGenerateSameName_WithDifferentSeed()
		{
			var generator1 = new ElvenNameGenerator(41);
			var generator2 = new ElvenNameGenerator(42);

			Assert.NotEqual(generator1.GenerateFullName().Take(1).First(),
				generator2.GenerateFullName().Take(1).First());
		}

		[Theory]
		[Repeat(20)]
		public void GeneratedName_ShouldNotContainSpace()
		{
			var name = _generator.GenerateName();
			
			Assert.DoesNotContain(" ", name);
		}
	}
}
