using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;

public class FirebaseManager : MonoBehaviour
{
    DatabaseReference reference;
    public Text takenString;

    private void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            if (task.Exception != null)
            {
                Debug.LogError("Firebase baþlatýlýrken bir hata oluþtu: " + task.Exception);
                return;
            }

            reference = FirebaseDatabase.DefaultInstance.RootReference.Child("yol");

            // ValueChanged olayýný dinleyerek gerçek zamanlý güncellemeleri izle
            reference.ValueChanged += HandleValueChanged;

            // Baþlangýçta bir kez deðeri al
            reference.GetValueAsync().ContinueWithOnMainThread(task =>
            {
                if (task.Exception != null)
                {
                    Debug.LogError("Firebase verisi alýnýrken bir hata oluþtu: " + task.Exception);
                    return;
                }

                DataSnapshot snapshot = task.Result;
                string receivedString = snapshot.Value.ToString();
                Debug.Log("Firebase'den alýnan string: " + receivedString);
                takenString.text = receivedString;
            });
        });
    }

    // Gerçek zamanlý güncellemeleri iþle
    void HandleValueChanged(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError("Firebase verisi alýnýrken bir hata oluþtu: " + args.DatabaseError.Message);
            return;
        }

        string receivedString = args.Snapshot.Value.ToString();
        Debug.Log("Firebase'den gerçek zamanlý olarak alýnan string: " + receivedString);
        takenString.text = receivedString;
    }
}
