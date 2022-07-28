using System.Text;

namespace Game {
  public class Game
  {
    private string _secretWord;
    public Game(string word) {
      _secretWord = word;
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


  }
}
