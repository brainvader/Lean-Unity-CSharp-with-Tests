using NUnit.Framework;

public class IterationTest {
    [Test]
    public void RepeatLetterFiveTimes() {
        var repeat = new Repeat('a');
        var repeated = repeat.letters();
        var expected = "aaaaa";

        Assert.AreEqual(repeated, expected);
    }
}
