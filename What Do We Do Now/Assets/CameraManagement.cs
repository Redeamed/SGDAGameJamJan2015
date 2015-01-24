using UnityEngine;
using System.Collections;

public class CameraManagement : MonoBehaviour {
    public Camera[] cameras;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void TriggerCrossed(GameObject trigger)
    {
        switch (trigger.name)
        {
            case "Trigger01":
                if (cameras[0].enabled)
                {
                    cameras[0].enabled = false;
                    cameras[1].enabled = true;
                }
                else if (cameras[1].enabled)
                {
                    cameras[1].enabled = false;
                    cameras[0].enabled = true;
                }
                else 
                {
                    Debug.Log("camera error");
                }
                break;
            case "Trigger02":
                break;

        }
    }
}
