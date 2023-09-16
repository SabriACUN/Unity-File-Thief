## Unity File Thief
In Unity, Take a file on the computer and sent them to your firebase storage. Collect files on a spesific location.

# Set Up
1- Open your new Unity Project  
FOR FIREBASE  
2- Go to : https://console.firebase.google.com/ , If you dont have any account, Sing Up  
3- Add new Project on firebase ; enter a name, Select default account for firebase  
4- Select Unity under the "Get started by adding Firebase to your app" text.  
5- Choose a register type.  
6- Download config file (2nd step) and SDK zip (3th step).  
7- Go to Your Project Console and open -> Build>Storage -> Get Started -> Next -> Done  
8- Under the "Storage" text, select Rules.  
9- Delete the texts of Rules File. And Copy and Paste that Rule :  
"""  
rules_version ='2';  
service firebase.storage{  
  match /b/{bucket}/o {  
    match /{allPaths=**} {  
      allow read, write:if true;  
    }  
  }  
}  
"""  
