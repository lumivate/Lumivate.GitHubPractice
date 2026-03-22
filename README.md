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

## How to Contribute
- On your PC, navigate to the folder you want to clone the repository into.
  - This is usually in C:\Users\me\source\repos\
- Right-click in the folder and select "Git Bash Here" to open the Git Bash terminal directly in that location.
  - Alternatively, you can open the "Git Bash" application from your start menu and navigate to the desired folder using the `cd` command.
- In github.com, click the green "Code" button and copy the URL of the repository. Make sure you are on the main page of the repository to find this button.
- Clone the repository to your local machine.
  - Go back to Git Bash, and type `git clone ` followed by the URL you copied from GitHub. 
  - For example: git clone https://github.com/johncross116/Lumivate.GitHubPractice.git
- In Git Bash, navigate to the newly cloned repository folder (cd Lumivate.GitHubPractice).
- Create a new branch. (git checkout -b my-branch-name)
- Open the app in Visual Studio (click the .sln file in the root folder of the repo).
- Open `src/QuizApp/QuizManager.cs`.
- Add a new `Quiz` object to the `_quizzes` list in the `LoadQuizzes` method.
- Add your questions.
- Stage your changes (git add src/QuizApp/QuizManager.cs)
- Commit (git commit -m "Add new quiz: [Your Quiz Name]")
- Push. Since you are checking your branch in for the first time you will need to add `origin` to tell it where to push to.
  - git push origin my-branch-name
- Head back to GitHub and you should see a prompt to create a pull request for your branch. Click that and fill out the form to submit your changes for review.
  - If you don't see the prompt, you can go to the "Pull Requests" tab in the repository and click "New Pull Request". Then select your branch from the dropdown menu to compare it with the main branch and create the pull request.
- That's it! One of the coaches will see your Pull Request and merge it in soon :)
