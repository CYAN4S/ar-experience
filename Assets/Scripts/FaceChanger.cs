using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceChanger : MonoBehaviour
{
    public List<GameObject> faces;

    private int _faceIndex;

    private ARFaceManager _fm;

    private void Start()
    {
        _fm = GetComponent<ARFaceManager>();
        _fm.facePrefab = faces[_faceIndex];
    }

    public void OnFaceChange()
    {
        _faceIndex = (_faceIndex + 1) % faces.Count;
        _fm.facePrefab = faces[_faceIndex];
    }
}