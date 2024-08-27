# Doofus Adventure Game

**Doofus Adventure Game** is a simple yet engaging game developed using Unity 3D. In this game, the player controls a cube character named Doofus that rolls across a series of platforms (Pulpits) which disappear after a few seconds. The goal is to keep Doofus moving from one platform to the next without falling off.

## Table of Contents

- [Features](#features)
- [Gameplay](#gameplay)
- [Installation](#installation)
- [Controls](#controls)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Simple but challenging gameplay**: Guide Doofus across disappearing platforms.
- **Start and End Screens**: Navigate between the game start, gameplay, and end screens.
- **Responsive Controls**: Use keyboard inputs to move Doofus.
- **Rolling Animation**: Doofus rolls realistically like a cube.
- **Visual Timer**: A 3-second timer is displayed on each platform before it disappears.
- **Customizable Settings**: Easily adjust game parameters such as platform size, speed, and more.

## Gameplay

- The game begins with a Start Menu where the player can initiate the game.
- Once the game starts, Doofus appears on the first platform. 
- Use the arrow keys to move Doofus to the next platform before the current one disappears.
- If Doofus falls, the game navigates to the End Screen, where the player can restart the game.

## Installation

### Prerequisites

- **Unity 2022 or above**: Download and install Unity from the [official website](https://unity.com/).
- **Git**: Ensure Git is installed on your machine for version control.

### Cloning the Repository

1. Open your terminal or command prompt.
2. Clone the repository using the following command:
   ```bash
   git clone https://github.com/yourusername/doofus-adventure-game.git
Open the project in Unity.
Setting Up the Project
Navigate to the Scenes folder and open SampleScene.
Press the Play button in the Unity editor to start the game.
Controls
Arrow Keys: Move Doofus horizontally and vertically.
Project Structure

Doofus Adventure Game/
├── Assets/
│   ├── Scripts/
│   │   ├── DoofusMovement.cs
│   │   ├── PulpitManager.cs
│   │   ├── GameController.cs
│   │   ├── UIManager.cs
│   │   └── ...
│   ├── Scenes/
│   │   ├── StartScene.unity
│   │   ├── SampleScene.unity
│   │   ├── EndScene.unity
│   │   └── ...
│   ├── Prefabs/
│   │   ├── Pulpit.prefab
│   │   └── ...
│   ├── Textures/
│   │   ├── hi.png
│   │   └── ...
│   └── ...
├── .gitignore
├── README.md
└── ...
Contributing
Contributions are welcome! If you have any ideas, suggestions, or bug reports, feel free to create an issue or submit a pull request.

How to Contribute
Fork the repository.
Create a new branch for your feature or bugfix:
bash
Copy code
git checkout -b feature-name
Commit your changes:
bash
Copy code
git commit -m "Add feature"
Push to the branch:
bash
Copy code
git push origin feature-name
Create a pull request.
License
This project is licensed under the MIT License. See the LICENSE file for more details.

Enjoy playing Doofus Adventure Game! If you like it, don't forget to star the repository on GitHub. 😊
