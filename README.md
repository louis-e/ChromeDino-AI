# ChromeDino-AI
 Documentation about the Chrome Dino Runner AI written in Visual Basic .Net and C#<br />
<br />
<br />
In der folgenden Dokumentation zeige ich den Ablauf der Vorgangsweise für den automatisierten Spielablauf des Chrome Dino Runner Spieles.
Folgendes wurden verwendet:<br />
-http://www.trex-game.skipser.com/ ........Klon des Spieles<br />
-Visual Basic .Net & C#....................................Das Projekt wurde in beiden Programmiersprachen umgesetzt. Die Performance beider Sprachen                                                werden desweiteren unten erklärt<br />
<br />
<br />
<br />
-Umsetzung:<br />
In beiden Sprachen wurde der selbe Algorithmus verwendet. Es gibt keinerlei Interaktionen mit der Website. Um ein Hindernis zu erkennen, liest das Programm die Pixelfarbe der geld markierten Stelle im unten abgebildetem Bild aus:
![Alt text](https://github.com/louis-e/ChromeDino-AI/blob/master/ki1.PNG "Die Stelle der auszulesenden Pixel sind gelb markiert") <br />
Hat die Farbe den Wert "[A=255, R=83, G=83, B=83]", welches der Farbe der Kakteen entspricht, wird ein Hindernis erkannt.
Da die gelb markierten XY Koordinaten je nach Monitorgröße variieren, ist die Funktion des aktuellen Projektes ohne Bearbeitung auszuschließen. Um das Projekt einwandfrei benutzen zu können, müssen aber nicht nur die Koordinaten der Hindernisse, sondern auch die Koordinaten der im unteren Bild markierten Stelle im Code editiert werden.
![Alt text](https://github.com/louis-e/ChromeDino-AI/blob/master/ki2.PNG "Die Stelle der auszulesenden Pixel sind gelb markiert") <br />
Diese dienen der Erkennung des "Game Overs". Sprich: Wenn das Spiel zu Ende ist, da die KI einen Fehler gemacht hat, erkennt das Programm das Spiel Ende und startet einen neuen Versuch.
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
-Performance
