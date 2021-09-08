public class Repeat {
    private char letter;
    public Repeat(char letter) {
        this.letter = letter;
    }
    public string letters() {
        var repeated = "";
        for (var i = 0; i < 5; i++) {
            repeated = repeated + this.letter;
        }
        return repeated;
    }
}
