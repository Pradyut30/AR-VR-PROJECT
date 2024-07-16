# AR-VR-PROJECT
INTRODUCTION
• We are going to use the unity to build a simple 3d game the
game is called as the coin collector in which we will collect the
coins with the ball. Unity has made the process of creating the
game easy with its editor which is supported on windows,
macOS and the linux platforms.
• Unity was developed in 2005 and ever since it has been one of
the most powerful tool to build the 3d games. Even today, the
game engine’s main focus is to both provide the most robust set
of tools possible for the game development industry, as well as
make it as easy as possible for game developers of any skill
level to use the engine .
• Unity provides support for both 3D and 2D graphics – allowing
us the freedom to choose the art style you want for our projects.
Each graphic type comes with its own specialized set tools (such
as sprite sheet cutting for 2D graphics) and even has its own
script APIs to call upon for different physics options that are
suited for each style.
• When it comes to VR and AR, which are newer technologies,
Unity is one of the key supporters for developing with them. For
VR, there are numerous packages available that support almost
all VR headsets available, and they are constantly updated and
kept flexible with this changing technology. Some of the popular
games that were built using this engine is pokemon go, fall
guys, cupheadand ,hollow knight etc.

QUICK START
• First download the unity hub by clicking on the following link
https://unity.com/download
• Choose your Unity version Install the latest version of Unity, an
older release, or a beta featuring the latest in-development
features https://unity.com/releases/editor/archive
• Start your project begin creating from scratch, or pick a template
to get your first project up and running quickly. Access tutorial
videos designed to support creators, from beginners to experts.

METHODOLOGY
1. Setting Up Player & Ground
• Creating the player and ground objects is one of the foundational
steps in developing a game in Unity. This process involves
setting up the game environment and configuring the player
character to interact with it. Below are detailed steps on how to
achieve this:
• Creating the player and ground objects is one of the foundational
steps in developing a game in Unity. This process involves
setting up the game environment and configuring the player
character to interact with it. Below are detailed steps on how to
achieve this:
Adjust Ground Properties:
• With the "Ground" object selected, go to the Inspector
window.
• Adjust the Scale properties to make the ground larger, if
needed. For example, you can set the scale to (10, 1,
10)to create a large flat surface.
• Optionally, apply a material to the ground to give it a texture.
Create a new material in the Project window by right-clicking
and selecting Create > Material. Then, assign this material
to the ground by dragging it onto the Plane object in the
Scene view or the Inspector window.
2. Coding Player Movement Setting Up Follow Camera
Once the player and ground are set up, the next step is to code
player movement, which involves writing scripts to control the
player's actions based on user input.
Create a New Script:
• In the Project window, right-click and select Create > C#
Script.
• Name the script "PlayerMovement".
Edit the PlayerMovement Script:
• Double-click on the "PlayerMovement" script to open it in
your code editor.
• Add the following code to handle player movement
Attach the Script to the Camera:
• Save the script and return to the Unity editor.
• Drag the "FollowCamera" script from the Project window
onto the Main Camera object in the Hierarchy window.
Configure the Camera:
• With the Main Camera selected, go to the Inspector window.
• In the FollowCamera script component, drag the "Player" object
from the Hierarchy window into the Playerfield.
• Adjust the Offset values to position the camera correctly
relative to the player. The offset is calculated automatically in
the Start method, but you can manually adjust it in the Inspector
for finer control.
3. Creating Collectable Coins
• Creating collectable coins in Unity involves several key steps,
starting with the design of the coin objects. To begin, a new 3D
object is created in the Unity editor by right-clicking in the
Hierarchy window and selecting 3D Object > Sphere. This
sphere will act as the coin. Renaming the object to "Coin" helps
keep the project organized. The coin's appearance is then
adjusted by scaling it to a thinner, more coin-like shape, such as
setting the scale to (0.5, 0.1, 0.5). Applying a material to the
coin enhances its visual appeal. This is done by creating a new
material, naming it "CoinMaterial," and setting its Albedo color
to yellow or another preferred coin color. This material is then
applied to the coin object, making it visually distinct.
• Next, the behavior of the coin is defined through scripting. A
new C# script named "Coin" is created in the Project window.
This script handles interactions between the coin and the player.
Opening the script in a code editor, the following code is added
to manage the coin's behavior when the player collects it
4. Collecting Coins
Add scripts to define the behavior of the coins, such as rotating
and detecting player collisions:
• Rotation Script: Add a script to make the coin rotate
continuously, making it more noticeable and visually appealing.
• Collision Detection: Add a script to detect when the player
collects the coin. This script will handle the collision event and
update the game state accordingly.
• Create a Game Manager script to keep track of the collected
coins and update the game score:
5. Creating Win Text UI
Creating a Win Text UI in Unity involves displaying a
message on the screen when the player meets the win
condition of the game ie when we collect all the coins, we
get a win text that is displayed on the screen.
• Create Canvas: In the Hierarchy, right-click and select UI >
Canvas. This will create a new Canvas object.
• Set Canvas Properties: Make sure the Canvas Render Mode is
set to Screen Space - Overlay, which is the default
mode and works well for most UI elements.
• Create Text Object: Right-click on the Canvas in the Hierarchy
and select UI > Text. This will create a new Text object as a
child of the Canvas.
• Position and Size Text: Adjust the RectTransform of the Text
object to position it in the desired location on the screen. You
can use the Anchor presets to center the text or place it at a
specific corner.
• Edit Text Properties: In the Inspector, customize the Text
component properties:
• Text: Set the default text to something like "You Win!".
• Font: Choose a font and adjust the size to make the text
readable.
• Alignment: Center the text both horizontally and vertically.
• Color: Choose a color that stands out against the background
6. Playing The Final Game
• Open Build Settings: Go to File > Build Settings.
• Scenes in Build: Ensure all necessary scenes are added to the
"Scenes in Build" list. Drag and drop scenes from the Project
window if needed.
• Platform Selection: Select the target platform (e.g., Windows,
Mac, Linux, Android, iOS) from the platform list. Click Switch
Platform to apply the changes.
• Build: In the Build Settings window, click Build.
• Save Location: Choose a location to save the built game files.
Create a new folder if necessary.
• Build Process: Unity will compile the game and generate the
executable or package file for the selected platform.

