using System.Text;

namespace Game {
  public class Game
  {
    // this is the field
    private string _secretWord;
    private int _counter;
    private readonly string[] DICTIONARY = {"MAKERS", "CANDIES", "DEVELOPER", "LONDON"};

    // this is the constructor
    public Game(string word) {
      _secretWord = word;
      _counter = 10;
    }

     public string GetWordToGuess() {
      StringBuilder builder = new StringBuilder();
      for (int counter = 0; counter < this._secretWord.Length; counter++) {
        char currentLetter = _secretWord[0];
        if (counter == 0) {
          builder.Append(currentLetter);
        } else {
          builder.Append("_");
        }
      }
    return builder.ToString();
    }

    public int GetRemainingAttempts() {
      return _counter;
    }

    public string GetRandomWordFromDictionary() {
      Random rand = new Random();
      return DICTIONARY[rand.Next(DICTIONARY.Length)];
    }

  }
}
