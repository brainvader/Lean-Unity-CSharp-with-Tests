using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    Hello hello1;

    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScriptSimplePasses()
    {
        var hello = new Hello("hello");
        // Use the Assert class to test conditions
        Assert.AreEqual("hi", hello.message);
    }
}
