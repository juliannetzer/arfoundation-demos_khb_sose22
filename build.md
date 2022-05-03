# Build auf iPads/iPhones

### Installation XCode (auf Euren Computern): 

Wenn ihr einen Mac habt, installiert zusätzlich XCode: 
[Get XCode](https://apps.apple.com/de/app/xcode/id497799835?mt=12)

Und erstellt euch einen Apple Developer Account: 
[Apple Developer Account](https://idmsa.apple.com/IDMSWebAuth/signin?appIdKey=891bd3417a7776362562d2197f89480a8547b108fd934911bcbea0110d07f757&path=%2Faccount%2F&rv=1)


### Einstellungen in Unity 

#### Beim ersten Mal/ Oder bei einer neuen Szene: Öffne die Build-Settings (File -> Build Settings)
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build1.png)
Stelle sicher, dass Platform auf iOS steht (wenn nicht, klicke auf iOS und klicke auf "Switch Platform")
Stelle sicher, dass sich alle Szenen (u), die du auf dem iPad haben willst sich in der Liste befinden (wenn nicht, entweder Drag & Drop in das Build Settings Fenster oder klick auf "Add Open Scenes")
Stelle sicher, dass sich die Szene, die du zuerst auf dem iPad sehen willst ganz oben in der Liste steht

#### Klicke auf Player Settings (Nur beim ersten Mal/Öffnen eines neuen Projekts)
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build2.png)
Ändert den Eintrag bei "Company" auf euren Namen/euren Gruppennamen, passt gerne auch den "Product Name" an

#### Klicke auf "Build And Run", wahlweise cmd + b im Editor-Fenster

### Einstellungen in XCode
##### Beim ersten Mal: Melde Dich mit deinem Apple Developer Account an: XCode -> Preferences -> Accounts
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build3.png)
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build4.png)

#### Wählt euer iPhone/ iPad aus der Liste aus:
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build5.png)

#### Klickt in der linken Leiste auf "Unity-iPhone" und geht zum Tab "Signing & Capabilities"
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build6.png)

#### Klickt auf "Automatically manage signing" und bestätigt nochmal
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build7.png)

#### Wählt eure "Team" aus 
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build8.png)
Evtl. müsst ihr im Anschluss nochmal auf "Try again" klicken

#### Klickt auf den Play-Button links oben 
![Build 1](https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/images_github/build9.png)