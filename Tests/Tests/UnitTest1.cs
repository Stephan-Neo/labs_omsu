namespace Tests;
using ConsoleApp1.tasks;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        Assert.AreEqual(4, Task.Calculator.Add(2,2));
    }
    
}