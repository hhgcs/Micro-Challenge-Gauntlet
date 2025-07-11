using Xunit;
using FizzBuzz.Core;

public class FizzBuzzTests
{
	[Theory]
	[InlineData(3, "Fizz")]
	[InlineData(5, "Buzz")]
	[InlineData(15, "FizzBuzz")]
	[InlineData(2, "2")]

	public void ReturnsExpected(int input, string expected)
		=> Assert.Equal(expected, FizzBuzzer.FizzBuzz(input));
}
