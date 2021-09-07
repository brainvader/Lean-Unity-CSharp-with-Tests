using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello 
{
    public string message;
    private const string spanish = "Spanish";
    private const string englishHelloPrefix = "Hello, ";
    private const string spanishHelloPrefix = "Hola, ";

    public Hello(string name) {
        var who = string.IsNullOrEmpty(name) ? "World" : name;
        this.message = englishHelloPrefix + who;
    }
}
