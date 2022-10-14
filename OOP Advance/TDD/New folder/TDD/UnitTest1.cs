namespace TDD;
[TestFixture]
public class Tests
{
    Maths operation =null;


    [SetUp]
    public void Setup()
    {
        operation=new Maths();


    }

    [Test]
    public void Test1()
    {
        int result=operation.Addition(10,11);

        Assert.That(result,Is.EqualTo(21));
    }
    [TestCase(10,20,30)]
    [TestCase(10,10,20)]
    public void IsAddition(int value1,int value2,int result)
    {
        int output=operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
    [TestCase(1.2,2.1,3.3)]
    public void IsAdditionOk(double value1,double value2,double result)
    {
        double output=operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
}