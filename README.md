Ball Collider Game made in Unity
====
HOW TO OPERATE THE SOLUTION
---
image source
---
<img src = "IMG-20180614-WA0042.jpg" width="100">

There are two methods to access the solution:

1. Go to the Ready_To_Look_Solutions/Build folder, you can check three solutions for different OS. WebGL works for any browser enabled system and to use that just open the HTML file in the WebGL folder. You can input the number of objects you want at the top panel

I have set the Timer to be 100 Seconds, to really change it, You will have to import the Unity_Package.(Prerequisite: Unity 5.6.6)

2. Import the package in Unity Editor and check the scripts:
	a. I have attached 5 scripts in total and they are pretty much explainable with the name and commenting(Feel free to hit me up in case of any doubts)
Hit the play button to run and specify the objects in the box
	b. To record the object movements at custom location, open the LogFIles Script and specify the path you want
	c. It is necessary to mention that the path originally provided in ready made solution might not exist due to system write permissions. Hence to really get all the logs modify the path in the code below(READ:https://docs.unity3d.com/ScriptReference/Application-persistentDataPath.html)
	d.one can modify the timer by selecting gamemanager object and then in the inspector tab(rightmost generally) look for the TImer script and put your favourite number
