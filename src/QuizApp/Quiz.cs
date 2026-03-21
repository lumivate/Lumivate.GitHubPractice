namespace QuizApp;

public class Quiz
{
    public string Theme { get; set; }
    public List<Question> Questions { get; set; }

    public Quiz(string theme, List<Question> questions)
    {
        Theme = theme;
        Questions = questions;
    }

    public void Play()
    {
        int score = 0;
        Console.WriteLine($"\n--- Starting Quiz: {Theme} ---");

        for (int i = 0; i < Questions.Count; i++)
        {
            var q = Questions[i];
            Console.WriteLine($"\nQuestion {i + 1}: {q.Text}");
            
            for (int j = 0; j < q.Options.Count; j++)
            {
                Console.WriteLine($"  {j + 1}. {q.Options[j]}");
            }

            int userChoice = -1;
            while (userChoice < 1 || userChoice > q.Options.Count)
            {
                Console.Write("Enter your answer (number): ");
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out userChoice) || userChoice < 1 || userChoice > q.Options.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option number.");
                }
            }

            if (userChoice - 1 == q.CorrectOptionIndex)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer was: {q.Options[q.CorrectOptionIndex]}\n");
            }
        }

        double percentage = (double)score / Questions.Count * 100;
        Console.WriteLine($"--- Quiz Complete! ---");
        Console.WriteLine($"Your Score: {score} out of {Questions.Count} ({percentage:F1}%)\n");
    }
}
