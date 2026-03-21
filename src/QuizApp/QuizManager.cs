namespace QuizApp;

public class QuizManager
{
    private List<Quiz> _quizzes;

    public QuizManager()
    {
        _quizzes = new List<Quiz>();
        LoadQuizzes();
    }

    private void LoadQuizzes()
    {
        // PR 1: Add first 2 themes
        _quizzes.Add(new Quiz("Space Exploration", new List<Question>
        {
            new Question("What is the largest planet in our solar system?", new List<string> { "Earth", "Mars", "Jupiter", "Saturn" }, 2),
            new Question("Who was the first person to walk on the moon?", new List<string> { "Buzz Aldrin", "Neil Armstrong", "Yuri Gagarin" }, 1),
            new Question("What galaxy is Earth located in?", new List<string> { "Andromeda", "Milky Way", "Triangulum" }, 1),
            new Question("Which planet is known as the Red Planet?", new List<string> { "Venus", "Mars", "Jupiter", "Uranus" }, 1)
        }));

        _quizzes.Add(new Quiz("Animal Trivia", new List<Question>
        {
            new Question("What is the fastest land animal?", new List<string> { "Cheetah", "Lion", "Horse", "Leopard" }, 0),
            new Question("Which bird is known for its beautiful tail feathers?", new List<string> { "Eagle", "Peacock", "Penguin" }, 1),
            new Question("What do pandas primarily eat?", new List<string> { "Fish", "Bamboo", "Insects", "Berries", "Nuts" }, 1)
        }));

        // PR 2: Add themes 3-5
        _quizzes.Add(new Quiz("Video Games", new List<Question>
        {
            new Question("What is the name of the plumber hero in Nintendo's most famous franchise?", new List<string> { "Luigi", "Mario", "Wario", "Toad" }, 1),
            new Question("In Minecraft, what material is needed to craft a Nether Portal?", new List<string> { "Iron", "Diamond", "Obsidian", "Gold" }, 2),
            new Question("Which game features the character Master Chief?", new List<string> { "Call of Duty", "Halo", "Destiny", "Gears of War" }, 1),
            new Question("What is the best-selling video game of all time?", new List<string> { "Tetris", "Minecraft", "GTA V", "Wii Sports" }, 1),
            new Question("In The Legend of Zelda, what is the name of the main hero?", new List<string> { "Zelda", "Ganon", "Link", "Navi" }, 2)
        }));

        _quizzes.Add(new Quiz("World Geography", new List<Question>
        {
            new Question("What is the capital city of Australia?", new List<string> { "Sydney", "Melbourne", "Canberra", "Brisbane" }, 2),
            new Question("Which is the longest river in the world?", new List<string> { "Amazon", "Nile", "Yangtze", "Mississippi" }, 1),
            new Question("What country has the most natural lakes?", new List<string> { "Russia", "Brazil", "Canada", "USA" }, 2),
            new Question("Which desert is the largest in the world?", new List<string> { "Gobi", "Sahara", "Arabian", "Antarctic" }, 3)
        }));

        _quizzes.Add(new Quiz("Classic Movies", new List<Question>
        {
            new Question("Who directed the movie Jaws (1975)?", new List<string> { "Stanley Kubrick", "Francis Ford Coppola", "Steven Spielberg" }, 2),
            new Question("In The Godfather, what animal's head is placed in a bed?", new List<string> { "Dog", "Horse", "Cow" }, 1),
            new Question("What is the name of the spaceship in Alien (1979)?", new List<string> { "Nostromo", "Discovery", "Sulaco", "Prometheus" }, 0),
            new Question("Which actor played Indiana Jones?", new List<string> { "Tom Hanks", "Harrison Ford", "Mel Gibson", "Clint Eastwood" }, 1),
            new Question("What year was the original Star Wars (A New Hope) released?", new List<string> { "1975", "1977", "1980", "1983" }, 1)
        }));
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("=== Welcome to the Ultimate Quiz App ===");
            Console.WriteLine("Select a theme to play:");
            
            for (int i = 0; i < _quizzes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_quizzes[i].Theme}");
            }
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");
            string? input = Console.ReadLine();
            
            if (int.TryParse(input, out int choice))
            {
                if (choice == 0)
                {
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    break;
                }
                else if (choice > 0 && choice <= _quizzes.Count)
                {
                    _quizzes[choice - 1].Play();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.\n");
            }
        }
    }
}
