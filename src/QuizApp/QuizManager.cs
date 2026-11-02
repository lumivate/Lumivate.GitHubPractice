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

        _quizzes.Add(new Quiz("Food and Cooking", new List<Question>
        {
            new Question("What is the main ingredient in traditional guacamole?", new List<string> { "Tomato", "Avocado", "Lime", "Onion" }, 1),
            new Question("Which country is the origin of sushi?", new List<string> { "China", "Korea", "Japan", "Thailand" }, 2),
            new Question("What type of pasta is shaped like small rice grains?", new List<string> { "Penne", "Orzo", "Fusilli", "Rigatoni" }, 1),
            new Question("What is the most consumed fruit in the world?", new List<string> { "Apple", "Mango", "Banana", "Orange" }, 2),
            new Question("What spice gives curry its yellow color?", new List<string> { "Cumin", "Paprika", "Turmeric", "Saffron" }, 2),
            new Question("How many cups are in a US gallon?", new List<string> { "8", "12", "16", "20" }, 2)
        }));

        _quizzes.Add(new Quiz("Sports", new List<Question>
        {
            new Question("How many players are on a standard soccer team on the field?", new List<string> { "9", "10", "11", "12" }, 2),
            new Question("In which sport would you perform a slam dunk?", new List<string> { "Volleyball", "Basketball", "Tennis", "Baseball" }, 1),
            new Question("How many holes are on a standard golf course?", new List<string> { "9", "12", "18", "24" }, 2),
            new Question("What country invented the Olympic Games?", new List<string> { "Italy", "Greece", "Egypt", "Rome" }, 1),
            new Question("In tennis, what is the term for a score of zero?", new List<string> { "Nil", "Zip", "Love", "Nought" }, 2)
        }));

        _quizzes.Add(new Quiz("Science Facts", new List<Question>
        {
            new Question("What is the chemical symbol for water?", new List<string> { "WA", "H2O", "HO2", "OW" }, 1),
            new Question("How many bones are in the adult human body?", new List<string> { "186", "196", "206", "216" }, 2),
            new Question("What is the speed of light approximately?", new List<string> { "300,000 km/s", "150,000 km/s", "450,000 km/s" }, 0),
            new Question("What planet is closest in size to Earth?", new List<string> { "Mars", "Venus", "Mercury", "Neptune" }, 1),
            new Question("What gas do plants absorb from the atmosphere?", new List<string> { "Oxygen", "Nitrogen", "Carbon Dioxide", "Hydrogen" }, 2),
            new Question("What is the powerhouse of the cell?", new List<string> { "Nucleus", "Ribosome", "Mitochondria", "Vacuole" }, 2),
            new Question("What is the atomic number of carbon?", new List<string> { "4", "6", "8", "12" }, 1)
        }));

        _quizzes.Add(new Quiz("Music Theory", new List<Question>
        {
            new Question("How many lines are on a standard musical staff?", new List<string> { "4", "5", "6", "8" }, 1),
            new Question("What does the musical term 'forte' mean?", new List<string> { "Soft", "Fast", "Loud", "Slow" }, 2),
            new Question("Which of these is not a musical clef?", new List<string> { "Treble", "Bass", "Alto", "Soprano" }, 3),
            new Question("How many beats does a whole note typically get in 4/4 time?", new List<string> { "1", "2", "3", "4" }, 3)
        }));

        _quizzes.Add(new Quiz("Git Basics", new List<Question>
        {
            new Question("Which command shows your working-tree status?", new List<string> { "git status", "git log", "git branch", "git remote -v" }, 0),
            new Question("Which command creates and switches to a new branch named nick/add-quiz?", new List<string> { "git checkout main", "git checkout -b nick/add-quiz", "git branch --show-current", "git pull" }, 1),
            new Question("Which command displays the name of your current branch?", new List<string> { "git diff", "git remote -v", "git branch --show-current", "git log -1" }, 2),
            new Question("Which command lists the configured remote URLs?", new List<string> { "git status", "git checkout main", "git branch", "git remote -v" }, 3),
            new Question("What does git pull --ff-only do when the histories have diverged?", new List<string> { "Creates a merge commit", "Refuses the update", "Deletes local commits", "Force-pushes the branch" }, 1)
        }));

        _quizzes.Add(new Quiz("Coding Basics", new List<Question>
        {
            new Question("What does HTML stand for?", new List<string> { "Hyper Text Markup Language", "High Tech Machine Learning", "Hyper Transfer Main Link" }, 0),
            new Question("Which symbol is commonly used to denote a comment in C#?", new List<string> { "#", "<!--", "//", "--" }, 2),
            new Question("What is the result of 5 % 2?", new List<string> { "2", "2.5", "1", "0" }, 2),
            new Question("Which data type is used to store a true or false value?", new List<string> { "int", "string", "boolean", "float" }, 2),
            new Question("What is an array?", new List<string> { "A function", "A collection of items", "A type of loop", "A database" }, 1)
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
