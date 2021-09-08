using NUnit.Framework;

public class IterationTest {
    [Test]
    public void RepeatLetterFiveTimes() {
        var repeated = new Repeat('a');
        var expected = "aaaaa";

        Assert.AreEqual(repeated, expected);
    }
}
