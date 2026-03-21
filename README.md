# Lumivate GitHub Practice - Quiz App

Welcome to the **Lumivate GitHub Practice** repository! This is a simple, easy-to-understand C# Console Application designed as a learning tool for students practicing Git commands and contributing to an open-source style project.

## About the App
The app is a multiple-choice Quiz game! It allows users to select from various fun themes and answer 3-7 questions per quiz. At the end of each quiz, the user receives their score as a percentage and a raw count (e.g., 3 out of 5 correct).

## Architecture Overview
The architecture is designed to be highly approachable for beginners:
- **`Program.cs`**: The entry point of the application.
- **`QuizManager.cs`**: Manages the list of available quizzes and handles the main menu loop.
- **`Quiz.cs`**: Represents a single quiz theme, containing a list of questions and the logic to play through them.
- **`Question.cs`**: A simple model representing a single multiple-choice question, its options, and the index of the correct answer.

Students can easily add new quizzes by adding a new `Quiz` object to the `_quizzes` list in `QuizManager.cs`.

## How to Run
1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Clone the repository.
3. Navigate to the `src/QuizApp` directory.
4. Run the command: `dotnet run`

## Current Themes
1. Space Exploration
2. Animal Trivia
3. Video Games
4. World Geography
5. Classic Movies
6. Food and Cooking
7. Sports
8. Science Facts
9. Music Theory
10. Coding Basics

## How to Contribute
1. Create a new branch.
2. Open `src/QuizApp/QuizManager.cs`.
3. Add a new `Quiz` object to the `_quizzes` list in the `LoadQuizzes` method.
4. Add your 3-7 questions.
5. Commit, push, and create a Pull Request!
