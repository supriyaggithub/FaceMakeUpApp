using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class ChangeMask : MonoBehaviour
{

    private ARFaceManager faceManager;
    public Material faceMaterial1;
    public Material faceMaterial2;
    public Material faceMaterial3;
    public Material faceMaterial4;
    public Material faceMaterial5;

    // Start is called before the first frame update
    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }

    // Update is called once per frame
    public void ApplyMaterial1()
    {
        foreach(ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterial1;
        }
        
    }
    public void ApplyMaterial2()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterial2;
        }

    }
    public void ApplyMaterial3()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterial3;
        }

    }
    public void ApplyMaterial4()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterial4;
        }

    }
    public void ApplyMaterial5()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterial5;
        }

    }
}
