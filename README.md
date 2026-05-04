# Chess Engine Project

A C# based implementation of the classic game of Chess, structured as a modular library with a dedicated console interface and testing suite.

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://dotnet.microsoft.com/) [![Status](https://img.shields.io/badge/Status-Development-yellow.svg)]()

## Table of Contents
- [About](#about)
- [Features](#features)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)

## About
This project provides a robust framework for managing a chess game, including piece logic, board state management, and move validation. It is designed with a separation of concerns, splitting core game logic into a class library for potential integration into other UIs.

## Features
-  **Modular Architecture**: Separate class library for game engine logic.
-  **Core Piece Logic**: Encapsulated rules for chess pieces and board interaction.
-  **Test-Ready**: Includes a dedicated project for unit testing game states.
-  **Console Interface**: Basic entry point for running the game locally.

## Project Structure
```text
chess/
├── ChessLibary/           # Core game engine and logic
│   ├── ChessField.cs   # Board logic
│   ├── Figure.cs       # Chess Pieces logic
├── ChessProgram/            # Console application entry point
├── ChessTests/               # Unit testing suite
└── Chess.sln         # Solution configuration
```

##  Installation
1. Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Clone the repository:
   ```bash
   git clone https://github.com/JackyyyGames/chess
   ```
3. Navigate to the root directory and build the solution:
   ```bash
   dotnet build
   ```

##  Usage
To run the application, navigate to the `ChessProgram` directory and execute:
```bash
dotnet run --project ChessProgram/ChessProgram.csproj
```

##  Contributing
Contributions are welcome! Please feel free to open issues or submit pull requests to help improve the game logic or add new features.
