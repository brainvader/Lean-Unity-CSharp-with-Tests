using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HelloTest
{
    Hello hello;

    [SetUp]
    public void Setup() {
        hello = new Hello("Chris");
    }

    // A Test behaves as an ordinary method
    [Test]
    public void SayHelloToPeople()
    {
        var want = "hi";
        var got = hello.message;
        // Use the Assert class to test conditions
        Assert.AreEqual(want, got);
    }
}
