using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HelloTest {
    // A Test behaves as an ordinary method
    [Test]
    public void SayHelloToPeople() {
        var hello = new Hello("Chris");
        var want = "Hello, Chris";
        var got = hello.message;
        // Use the Assert class to test conditions
        Assert.AreEqual(want, got);
    }

    [Test]
    public void SayHelloWorldWhenEmptyString() {
        var hello = new Hello("");
        var got = hello.message;
        var want = "Hello, World";

        Assert.AreEqual(want, got);
    }

    [Test]
    public void SayHelloInSpanish() {
        var hello = new Hello("", "Spanish");

        var got = hello.message;
        var want = "Hola, World";

        Assert.AreEqual(want, got);
    }
}
