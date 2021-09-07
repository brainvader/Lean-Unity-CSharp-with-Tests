using NUnit.Framework;


public class IntegersTest {

    [Test]
    public void AddTwoIntegers() {
        var adder = new Add(2, 2);
        var sum = adder.Compute();
        var expected = 4;

        Assert.AreEqual(sum, expected);
    }
}
