# ChromeDino-AI
 Documentation about the Chrome Dino Runner AI written in Visual Basic .Net and C#<br />
<br />
<br />
...................GERMAN/DEUTSCH...................
<br />
In der folgenden Dokumentation zeige ich den Ablauf der Vorgangsweise für den automatisierten Spielablauf des Chrome Dino Runner Spieles.
Folgendes wurden verwendet:<br />
-http://www.trex-game.skipser.com/ ........Klon des Spieles<br />
-Visual Basic .Net & C#....................................Das Projekt wurde in beiden Programmiersprachen umgesetzt. Die Performance beider Sprachen sind gleich<br />
<br />
<br />
<br />
-Umsetzung:<br />
In beiden Sprachen wurde der selbe Algorithmus verwendet. Es gibt bis auf das Senden der Tasten Space und Down keinerlei Interaktionen mit der Website. Um ein Hindernis zu erkennen, liest das Programm die Pixelfarbe der gelb markierten Stelle im unten abgebildetem Bild aus:<br />
![Alt text](https://github.com/louis-e/ChromeDino-AI/blob/master/ki1.PNG "Die Stelle der auszulesenden Pixel sind gelb markiert") <br />
Hat die Farbe den Wert "[A=255, R=83, G=83, B=83]", welches der Farbe der Kakteen entspricht, wird ein Hindernis erkannt.
Da die gelb markierten XY Koordinaten je nach Monitorgröße variieren, ist die Funktion des aktuellen Projektes ohne Bearbeitung auszuschließen. Um das Projekt einwandfrei benutzen zu können, müssen aber nicht nur die Koordinaten der Hindernisse, sondern auch eine Pixelkoordinate der im unteren Bild markierten Stelle im Code editiert werden.<br />
![Alt text](https://github.com/louis-e/ChromeDino-AI/blob/master/ki2.PNG "Die Stelle der auszulesenden Pixel sind gelb markiert") <br />
Diese dienen der Erkennung des "Game Overs". Sprich: Wenn das Spiel zu Ende ist, da die KI einen Fehler gemacht hat, erkennt das Programm das Spiel Ende und startet einen neuen Versuch. <br />
[In diesem Video ist ein Durchgang der C# Version zu sehen](https://www.youtube.com/watch?v=0_pkAlh1k1Y)<br />
<br />
<br />
Der C# Code ist ausführlich beschrieben.
<br />
<br />
<br />
<br />
...................ENGLISH/ENGLISCH...................
<br />
In the following documentation we show you the process of the automated gameplay of the Chrome Dino Runner game. We used:<br />
-http://www.trex-game.skipser.com/ ........ clone of the game<br />
-Visual Basic .Net & C# ................................... The project was written in both programming languages. <br />
<br />
<br />
<br />
-Implementation:<br />
Both languages are using the same algorithm. There are no interactions with the website to detect the obstacles. To detect an obstacle, the program reads the color of the yellow marked pixel:
![Alt text](https://github.com/louis-e/ChromeDino-AI/blob/master/ki1.PNG "The location of the pixels to be read are marked in yellow") <br />
If the color has the value "[A=255, R=83, G=83, B=83]", which is the color of the cactus, an obstacle is detected. Since the yellow XY coordinates vary depending on the monitor size, the function of the current project must be excluded without editing. 
In order to be able to use the project without error, the coordinates of the obstacles and a pixel coordinate in the marked area, which can be seen below, must be edited in the code.
![Alt text](https://github.com/louis-e/ChromeDino-AI/blob/master/ki2.PNG "The location of the pixels to be read are marked in yellow") <br />
These are used to recognize the "Game Overs". So, when the game is over, the program detects the end and starts a new attempt.<br />
[This video shows a passage of the C# version](https://www.youtube.com/watch?v=0_pkAlh1k1Y)<br />
<br />
<br />
The C# code is described in detail.
