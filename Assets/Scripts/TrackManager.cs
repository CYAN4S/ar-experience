using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class TrackManager : MonoBehaviour
{
    public Text label;
    private ARTrackedImageManager _trackedImageManager;

    private void Awake()
    {
        _trackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    private void Update()
    {
        foreach (var trackedImage in _trackedImageManager.trackables) label.text = $"{trackedImage.transform.position}";
    }
}