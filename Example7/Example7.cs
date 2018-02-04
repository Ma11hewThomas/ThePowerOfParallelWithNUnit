using System.Threading;
using NUnit.Framework;

[TestFixture]
public class TestFixture1
{
    [Test, Parallelizable(ParallelScope.Self)]
    public void TestMethod1()
    {
        Thread.Sleep(5000);
        Assert.IsTrue(true);
    }
    [Test, Parallelizable(ParallelScope.Self)]
    public void TestMethod2()
    {
        Thread.Sleep(5000);
        Assert.IsTrue(true);
    }
}
[TestFixture]
public class TestFixture2
{
    [Test, Parallelizable(ParallelScope.Self)]
    public void TestMethod3()
    {
        Thread.Sleep(5000);
        Assert.IsTrue(true);
    }
    [Test, Parallelizable(ParallelScope.Self)]
    public void TestMethod4()
    {
        Thread.Sleep(5000);
        Assert.IsTrue(true);
    }
}
