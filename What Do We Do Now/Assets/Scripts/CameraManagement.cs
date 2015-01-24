using UnityEngine;
using System.Collections;

public class CameraManagement : MonoBehaviour {
    public Camera[] cameras;
    public Camera currCamera;
	// Use this for initialization
	void Start () 
    {
        currCamera = cameras[0];
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void TriggerCrossed(Camera[] cams)
    {
       int length = cams.Length;
        for(int i = 0; i < length; ++i)
        {
            if (cams[i].enabled)
            {
                cams[i].enabled = false;
                if (i + 1 < length)
                {     
                    currCamera = cams[i + 1];
                }
                else 
                {
                    currCamera = cams[0];

                }
                currCamera.enabled = true;
                break;
            }
        }
    }
    public Camera getCurrCamera() 
    {
        return currCamera;
    }
}
