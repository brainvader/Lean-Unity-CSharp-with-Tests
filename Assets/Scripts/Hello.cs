using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello 
{
    public string message;
    private const string englishHelloPrefix = "Hello, ";

    public Hello(string name) {
        this.message = englishHelloPrefix + name;
    }
}
