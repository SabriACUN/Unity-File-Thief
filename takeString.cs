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
                Debug.LogError("Firebase ba�lat�l�rken bir hata olu�tu: " + task.Exception);
                return;
            }

            reference = FirebaseDatabase.DefaultInstance.RootReference.Child("yol");

            // ValueChanged olay�n� dinleyerek ger�ek zamanl� g�ncellemeleri izle
            reference.ValueChanged += HandleValueChanged;

            // Ba�lang��ta bir kez de�eri al
            reference.GetValueAsync().ContinueWithOnMainThread(task =>
            {
                if (task.Exception != null)
                {
                    Debug.LogError("Firebase verisi al�n�rken bir hata olu�tu: " + task.Exception);
                    return;
                }

                DataSnapshot snapshot = task.Result;
                string receivedString = snapshot.Value.ToString();
                Debug.Log("Firebase'den al�nan string: " + receivedString);
                takenString.text = receivedString;
            });
        });
    }

    // Ger�ek zamanl� g�ncellemeleri i�le
    void HandleValueChanged(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError("Firebase verisi al�n�rken bir hata olu�tu: " + args.DatabaseError.Message);
            return;
        }

        string receivedString = args.Snapshot.Value.ToString();
        Debug.Log("Firebase'den ger�ek zamanl� olarak al�nan string: " + receivedString);
        takenString.text = receivedString;
    }
}
