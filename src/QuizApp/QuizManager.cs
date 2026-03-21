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
