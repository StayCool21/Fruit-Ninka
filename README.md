# Fruit Ninka
![Fruit Ninka Original Logo](/GitHub%20Assets/FruitNinkaFull.png)

Fruit Ninka is a parody of Halfbrick Studio's **Fruit Ninja**, released in 2010 on the iOS App Store. In Fruit Ninja, the player attempts to slice fruit launched upwards by slicing/swiping across the screen while avoiding bombs.

## Why the name?
While I was typing in the project name in Unity Editor, I accidentally typed the second word in wrong. I guess you could say it's a "happy accident" since it was very easy for me to whip up a new logo in GIMP.

## Features
![Gameplay Image](/GitHub%20Assets/NormGamePlay.JPG)
+ Five models of fruit that can be sliced
+ Ability to change bomb probabilities/fruit point allocations
+ Score Tracking (top left)
+ Auto-reset after slicing a bomb (I'll improve this in the future)

## Mechanics
All in-game logic (scoring, spawning, etc.) was developed using C#, Unity's scripting language. Seeing as though most of my college CS courses have used C++ for development, I found the syntax to not be too much of a change from what I'm normally used to. This was also a good referesher in objects and classes, something I desperately need to be doing more often. 



## Running the Game
Simply clone this repo to a local machine and extract the **Fruit Ninka** directory. Run the **Fruit Ninka.exe** file located at `...\Fruit Ninka\BuildHere `. The game should start in fullscreen mode.

## Known Issues
+ There is currently no way to pause the game at any point. The only way to exit this game is to probably do the Task Manager way, or **Win** key to bring up the taskbar and close the window.
+ There also isn't any record-keeping going on. I'm hoping to implement some sort of system to gather records as this game progresses.
## Future Goals
+ Implement better fruit models/more fruit models in general 
  - We need more sophisticated fruits than just colored cylinders.
  - Will be updated in **version 0.2**.
+ Implement better menus
  - Splash screen (I don't know exactly what that is at the moment...)
  - New Title Menu, allowing user to start/exit game to desktop
  - Pause/restart option during gameplay
+ Records
  - Need a way to track Personal Best, maybe combos as well
  - Displayed during gameplay and/or on title screen
+ Sounds
  - Musical track to accompany title screen as well as during game
  - Slicing sounds for fruit and bombs (of course)
+ Multiple Game Modes
  - Add different difficulty levels
  - Maybe add special fruit with different point allocations?

