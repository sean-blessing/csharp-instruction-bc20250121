using ConsoleUtil;

namespace Hangman {
    internal class Program {
        static string[] images = new string[7];
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the hangman game!\n");
            PopulateImages();

            for (int i = 0; i < images.Length; i++) {
                MyConsole.PrintLine($"Image {i}");
                MyConsole.PrintLine(images[i]);
                MyConsole.PrintLine("============");
            }
                

            MyConsole.PrintLine("\nBye");
        }

        private static string GetHangmanImage(int incorrectGuesses) {
            return images[incorrectGuesses];
        }

        private static void PopulateImages() {
            images[0] =
            """
                -----
                |   |
                |
                |
                |
                |
                -------
            """;
            images[1] =
            """
                -----
                |   |
                |   O
                |
                |
                |
                -------
            """;
            images[2] =
            """
                -----
                |   |
                |   O
                |   |
                |
                |
                -------
            """;
            images[3] =
            """
                -----
                |   |
                |   O
                |  /|
                |
                |
                -------
            """;
            images[4] =
            """
                -----
                |   |
                |   O
                |  /|\
                |
                |
                -------
            """;
            images[5] =
            """
                -----
                |   |
                |   O
                |  /|\
                |  /
                |
                -------
            """;
            images[6] =
            """
                -----
                |   |
                |   O
                |  /|\
                |  / \
                |
                -------
            """;
        }
    }
}
