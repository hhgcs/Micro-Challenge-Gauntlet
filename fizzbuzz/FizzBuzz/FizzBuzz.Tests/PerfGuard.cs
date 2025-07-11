using System.Diagnostics;
using Xunit;
using FizzBuzz.Core;

public  class PerfGuard 
{
	[Fact]
	public void SeventhCallSubMicrosecond() 
	{
		var sw = new Stopwatch();
		FizzBuzzer.FizzBuzz(0);

		for (int i = 0; i < 7; i++) 
		{
			sw.Restart();
			FizzBuzzer.FizzBuzz(i);
			if (i==6) {
				sw.Stop();
				double micro = sw.ElapsedTicks * 1_000_000.0 / Stopwatch.Frequency;
				Assert.True(micro <= 1, $"Took {micro:F2} µs");
			}
		}
	}
}
