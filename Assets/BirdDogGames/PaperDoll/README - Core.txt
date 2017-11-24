----------------------------------------------
               PaperDoll - Core
    Copyright © 2016 - 2017 Bird Dog Games
               Version 1.00.02
          twitter.com/birddoggames
          support@BirdDogGames.com
----------------------------------------------

Thank you for downloading PaperDoll - Core!

This package provides support for tinting and customizing paper dolls from Bird Dog Games.  It also contains a simple demo that you can run in the Unity Editor to see your installed paper dolls in action.

Don't have any paper dolls yet?  A simple robot paper doll is included in Core for you to try out.  For other dolls, simply head over to the Unity Asset Store and pick some up today: https://goo.gl/igW2MI


-----------------
 Prerequisites
-----------------

PaperDoll - Core requires the Spine runtime from Esoteric. We are currently compatible with their 3.6 October 31, 2017 release.  You may download and install the spine-unity runtime from Esoteric:

    http://esotericsoftware.com/spine-unity-download/

It is important to note that the runtime is only free for non-commercial use.  If you plan to legally sell a game that includes the Spine runtime, you'll need to purchase a license of Spine from Esoteric.


-----------------
 Examples
-----------------

There is a simple demo called Walker in the Examples folder.  Open the Walker.scene and press play to give it a try.  The demo will find all of the paper dolls you currently have installed and use them to build a very simple "endless walker".  One of the dolls will be chosen and spawned as your "walker" and he or she will begin walking on their own.  Periodically, other dolls will appear in the scene performing one of their animations at random.  Sit back and enjoy the silliness.

Feel free to re-run the demo when you've installed other dolls, to see them included as well.


-----------------
 Next Steps
-----------------

To create your own doll, create a new GameObject and add the DollInstance component.  You will see a drop down listing all of the dolls found in your project.


-----------------
 Version History
-----------------

1.00.02
	* Updated to match refactoring done by Spine-unity.
	
1.00.01
	* First release!