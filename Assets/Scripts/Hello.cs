using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello {
    public string message;
    private const string spanish = "Spanish";
    private const string englishHelloPrefix = "Hello, ";
    private const string spanishHelloPrefix = "Hola, ";

    public Hello(string name, string language = "English") {
        var who = string.IsNullOrEmpty(name) ? "World" : name;

        var prefix = englishHelloPrefix;

        switch (language) {
            case spanish:
                prefix = spanishHelloPrefix;
                break;
            default:
                break;
        }
        if (language == spanish) {
            this.message = prefix + who;
        } else {
            this.message = prefix + who;
        }
    }
}
