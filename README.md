# ComicBookARCover
######Description######

This project is an augmented reality cover for the comic book, The Mighty Thor #337. It's goal is to add depth and movement to the cover to make them both feel more interactive and entertaining. The front cover will show Beta Ray Bill and the depth between him and the titles. The back cover will show an advertisement for the Atari game, Star Wars: Return of the Jedi (Death Star Battle). The front can be moved around to view the depth and make the cover feel more alive. As the title, "Thor", is being destroyed in the cover, I made the small rocks or parts of the title stick out at different heights from the cover itself. With the original cover, you could not see the whole image of Beta Ray Bill. With this added depth, you can actually see behind the title and see his other hand, for example. Adds a new view of the character. The back will show a video for both the Atari game itself and the movie the adverstisement is based on. I thought adding a video would make the scene more interesting. I also added 2 X-Wings and the Death Star to add some more interesting visuals and test more with 3D models. The 2D sprites I worked with acted like these 3D models, but I did want to include both. Clicking on the screen will toggle between comic book information and review. Opacity was included for visability.

**Interaction**

Holding up an image of the cover should allow for the program to start tracking it's movement. Clicking anywhere on the screen should allow for the user to switch between title information and review information on the front, while the back contains more detailed title information and the review. Continuing to click should cycle between no text showing, these title informations, and review for the front and back. Users should be able to view all around the front cover and back.

**Limitations**

The back cover does suffer from a bit of lag and have a hard time tracking the object, but I believe that is from the 3D models included. Previous builds did not have these models and it worked without any lag. A second limitation is the interaction, partially from creating a workaround the virtual button for Vuforia being removed. Tapping on the screen is connected for both the front and back. This leads to them having to be synced and if the front changes, the back also does since inside of my "ButtonToggle" script, it recieves mouse input/screen input. I tried with a 3D box collider on both sides of the cover and then a script to recognize tehse colliders as buttons, but that did not work I believe because of the Vuforia movement. I also tried to track if the front of the back of the book was being shown, but this also had it's own issues. I tried to change it through a script, but all the information I could find was over the command "trackableBehavior". This was also removed and replaced with another called "ObserverBehavior". "ObserverBehavior" did not have much information on it except for the description on Vuforia's documentation, but this did not help much with using it inside of a script. I also tried to use 2D buttons, but this would have to cover the screen and even with opacity, it still needed to know which side of the screen was being shown. I decided to just stick with having them change together as many of these other options did not lead anywhere and the current way of having the front and back move together does not hurt anything. I just had to make sure that the front and back had the same amount of screens/text so they sync. Overall, there were not many limitations besides these 2 issues.

**Struggles**

Layering of the sprites was a large issue I ran into. Before I added them to different sorting layers, they would clip into each other, even though they were on different heights. Adding the sorting value made it so that the sprites stayed above each other at all times. Another issue was trying to get the sprites themselves, but that was more of a modeling issue. I had to color in an original image of the cover without the text from the original artist to get the effect I wanted with being able to see under the text. The on-click issues I listed in the limitations was another struggle I had, which I was not able to fully figure out how I wanted. Finally, the last big struggled I've faced was uploading the project to GitHub. A few of the files are actually a bit too big for it, so I had to compress them using a compressor code I found online then have a ".gitignore" file to ignore all of the extra libraries.

**Installation**

I should have included the entire Unity project inside of this GitHub project. Downloading it and opening it inside of Unity with Vuforia installed should allow for the user to access the project and make edits. Inside of the project, there are 2 folders known as "BuildAndroid" and "BuildIOS". These include builds for both platforms. Dragging the APK file in "BuildAndroid" should allow the project to run on Android devices, while uploading the XCode file to the XCode program with phone attached should allow for the user to move the file over and use the project on an IOS device. Vuforia may need to be installed seperately if user does not have it already. I used an Android device and dragged it into my device's file system, then opened the file called "Thor #337 Comic Book Cover" to install the application.
