# ThePowerOfParallelWithNUnit
### Code examples to accompany http://matthewthomas.tech/nunit-parallel/

![full-nunit-demo](http://matthewthomas.tech/content/images/2018/02/full-nunit-demo.gif)

## Example 1 - no parallelism specified
When no parallelism is specified, tests run concurrently by default.

## Example 2 - assembly level with a fixture scope
Add *\[assembly: Parallelizable(ParallelScope.Fixtures)]* to the *AssemblyInfo.cs*.
Test fixtures can run in parallel, resulting in *TestMethod1* and *TestMethod3* running first, then *TestMethod2* and *TestMethod4* running after.


## Example 3 - assembly level with a children scope
Add *\[assembly: Parallelizable(ParallelScope.Children)]* to the *AssemblyInfo.cs*.
All *TestMethods* run in parallel as they are descendants of the assembly.


## Example 4 - TestFixture1 and TestFixture2 with a fixture scope
Add *\[TestFixture, Parallelizable(ParallelScope.Fixtures)]* to *TestFixture1* and *TestFixture2*
Test fixtures can run in parallel, resulting in *TestMethod1* and *TestMethod3* running first, then *TestMethod2* and *TestMethod4* running after.


## Example 5 - TestFixture1 with a children scope
Add *\[TestFixture, Parallelizable(ParallelScope.Children)]* to *TestFixture1* and *TestFixture2*
Decendants of *TestFixture1* can run in parallel however decendants of *TestFixture2* can not therefore *TestMethod1* and *TestMethod2* run in parallel, however *TestMethod3* and *TestMethod4* run concurrently after *TestMethod1* and *TestMethod2* have finished.


## Example 6 - TestFixture1 and TestFixture2 with a children scope
Add *\[TestFixture, Parallelizable(ParallelScope.Children)]* to *TestFixture1* and *TestFixture2*
Decendants of *TestFixture1* and *TestFixture2* can run in parallel however the test fixtures can not run in parallel with each other therefore *TestMethod1* and *TestMethod2* run in parallel, followed by *TestMethod3* and *TestMethod4* in parallel.

## Example 7 - TestMethod1, TestMethod2, TestMethod3 and TestMethod4 with a self scope
Add *\[Test, Parallelizable(ParallelScope.Self)]* to all *TestMethods*
All TestMethods can run in parallel, however TestFixtures can't therefore *TestMethod1* and *TestMethod2* run in parallel, followed by *TestMethod3* and *TestMethod4* in parallel.


## Example 8 - Assembly1 with a fixture scope and TestFixture1 with a children scope
Add *\[assembly: Parallelizable(ParallelScope.Fixtures)]* to the *AssemblyInfo.cs* and Add *\[TestFixture, Parallelizable(ParallelScope.Children)]* to *TestFixture1*
*TestFixtures* can run in parallel and descendants of *TestFixture1* can run in parallel therefore *TestMethod1*, *TestMethod2* and *TestMethod3* run in parallel. *TestMethod4* runs after the others as decendants of *TestFixture2* can not run in parallel with each other.


## Example 9 - Assembly1 with a children scope and TestMethod1 with NonParallelizable
Add *\[assembly: Parallelizable(ParallelScope.Children)]* to the *AssemblyInfo.cs*  and add *\[Test, NonParallelizable]* to *TestMethod1*
Decendants of *Assembly1* can run in parallel however, *TestMethod1* can not be run in parallel with any other test therefore *TestMethod2*, *TestMethod3* and *TestMethod4* run in parallel, followed by *TestMethod1*.
