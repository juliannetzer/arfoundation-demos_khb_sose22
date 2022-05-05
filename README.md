# Unitypackage - Edge of Chaos SoSe 22 - khb 

Inhaltsverzeichnis: 
* Regeln für das Arbeiten mit dem Repo
* Workshop 02.05.
	* [Installation](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/installation.md)
	* [Unity UI-Basics/ Shortcuts](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/Handouts/220501_UnityCheatsheet.pdf)
	* [Build/ App auf dem iPad installieren](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/build.md)
* Workshop 11.05. 
	* [Aufbau der Demo-Szenen](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/demoscenes.md)
	* [Materialien](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/materialien.md)
	* [Licht & Schatten](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/LichtSchatten.md)
	* [Animation & Interaktion]((https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/AnimationInteraktion.md))




## Regeln für das Arbeiten mit dem Repo: 

Das Repo besteht aus zwei Hauptordnern: 
- 01_Demo_Scenes 
	Hier finden sich die Demo-Szenen, die euch als Startpunkt dienen können. 
- 02_ProjectFiles
	Hier finden sich eure Unity-Szenen, bitte speichert hier alle eure Objekte/Unitydateien ab. Am besten ihr legt euch bevor ihr anfangt zu arbeiten einen eigenen Ordner innerhalb des Projectfiles-Ordner (siehe Beispielordner)

1. Bitte lasst den "01_Demo_Scenes" Ordner unangetastet. Ihr könnt natürlich gerne alle Scripte/Objekte verwenden oder verändern, aber bitte macht das im jeweiligen Ordner eurer Gruppe. Wenn ihr ein Script/Prefab etc. verändert, kopiert es bitte zuerst in euren jeweiligen Ordner. 

2. Bitte achtet darauf, dass ALLE Objekte/Scripte/Szenen/Materialien etc., die ihr erstellt/verändert habt sich in Eurem Gruppenordner befinden!



## Demoszenen: 

### 00_FreePlacement: 

Einfachste Art eine AR-Arbeit im Raum zu platzieren, die Arbeit erscheint beim Öffnen der App relativ zu eurer Startpostition im Raum. Geeignet, wenn eure Arbeit keine exakte Platzierung im Raum braucht. 

### 01_PlanePlacement:

Platziert eine AR-Arbeit auf einer Fläche im Raum (wahlweise auf dem Boden oder an der Wand). Der Benutzer kann nach der Initialisierung selbst die Position der Arbeit bestimmen. 

### 02_ImageTracking: 

Platziert eine AR-Arbeit auf einem Image Marker. Geeignet wenn eure Arbeit an einem exakten Ort platziert werden soll, bzw. ein Objekt überlagern soll. Hier gibt es zwei Beispielszenen, einmal mit einem Image Marker, der zu einem Objekt gehört und eine Version mit mehreren Imagemarkern, die zu mehreren Objekten gehören. 

### 03_Animation: 

Einfaches AR-Objekt mit einer Beispiel-Animation. 

### 04_Interaction: 

Zwei Szenen mit Interaktion: einmal wird eine Animation beim Klick auf einen Button abgespielt, einmal beim direkten Klicken auf das Objekt. 
