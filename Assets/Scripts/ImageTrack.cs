using UnityEngine;
using Vuforia;

public class ImageTargetTracker : MonoBehaviour
{
    private ObserverBehaviour observer; // Reference to the Vuforia Image Target

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour observer, TargetStatus status)
    {
        if (status.Status == Status.TRACKED)
        {
            Debug.Log("Image Target Found: " + observer.TargetName);
        }
        else
        {
            Debug.Log("Image Target Lost: " + observer.TargetName);
        }
    }
}
