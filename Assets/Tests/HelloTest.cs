using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HelloTest
{
    Hello hello;

    // A Test behaves as an ordinary method
    [Test]
    public void SayHelloToPeople()
    {
        var want = "Hello, Chris";
        var got = hello.message;
        // Use the Assert class to test conditions
        Assert.AreEqual(want, got);
    }

    [Test]
    public void SayHelloWorldWhenEmptyString() {
        var got = hello.message;
        var want = "Hello, World";

        Assert.AreEqual(got, want);
    }
}
