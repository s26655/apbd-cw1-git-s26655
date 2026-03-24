# Statistics Calculator

A simple C# .NET console application used to practice Git and GitHub workflows, including branching, merging, rebasing, and conflict resolution.

## Features

- Display input numbers
- Calculate average value
- Calculate maximum and minimum values

## Answers

### 1. When does Git perform a fast-forward and when is a merge commit created?

Git performs a fast-forward when the target branch has no new commits after the feature branch was created. In that case, Git only moves the branch pointer forward.

A merge commit is created when both branches contain new commits and their histories have diverged. Git must then create an extra commit that joins both lines of development.

### 2. What is the practical difference between merge and rebase?

Merge preserves the original branch structure and creates a merge commit when needed. It shows the real history of parallel work.

Rebase rewrites the feature branch commits on top of a newer base commit. This makes the history cleaner and more linear, but it changes commit hashes.

### 3. How was the conflict resolved in your repository?

The conflict was created by modifying the same result-summary section in `Program.cs` differently on `main` and on `feature-conflict`.

It was resolved manually by combining both changes: the final version kept the classification-style message from `main` and the more detailed range summary from `feature-conflict`.

After resolving the conflict, the file was tested again and the code still worked correctly.