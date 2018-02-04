using System.Threading;
using NUnit.Framework;

[TestFixture, Parallelizable(ParallelScope.Fixtures)]
public class TestFixture1
{
    [Test]
    public void TestMethod1()
    {
        Thread.Sleep(5000);
        Assert.IsTrue(true);
    }
    [Test]
    public void TestMethod2()
    {
        Thread.Sleep(5000);
        Assert.IsTrue(true);
    }
}
[TestFixture, Parallelizable(ParallelScope.Fixtures)]
public class TestFixture2
{
    [Test]
    public void TestMethod3()
    {
        Thread.Sleep(5000);
        Assert.IsTrue(true);
    }
    [Test]
    public void TestMethod4()
    {
        Thread.Sleep(5000);
        Assert.IsTrue(true);
    }
}
