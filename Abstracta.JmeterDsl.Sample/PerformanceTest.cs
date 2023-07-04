namespace Abstracta.JmeterDsl.Sample;

using static Abstracta.JmeterDsl.JmeterDsl;

public class PerformanceTest
{
    private TextWriter? originalConsoleOut;

    // Redirecting output to progress to get live stdout with nunit.
    // https://github.com/nunit/nunit3-vs-adapter/issues/343
    // https://github.com/nunit/nunit/issues/1139
    [SetUp]
    public void SetUp()
    {
        originalConsoleOut = Console.Out;
        Console.SetOut(TestContext.Progress);
    }

    [TearDown]
    public void TearDown()
    {
        Console.SetOut(originalConsoleOut!);
    }

    [Test]
    public void LoadTest()
    {
        var stats = TestPlan(
                ThreadGroup(1, 1,
                    HttpSampler("https://abstracta.us")
                )
            ).Run();
        Assert.That(stats.Overall.SampleTimePercentile99, Is.LessThan(TimeSpan.FromSeconds(5)));
    }
}