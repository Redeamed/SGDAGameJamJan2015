using UnityEngine;
using System.Collections;

public class CamTrigger : MonoBehaviour {
    CameraManagement cameraManage;
	// Use this for initialization
	void Start () 
    {
        cameraManage = GetComponentInParent<CameraManagement>();
	}
	
	// Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cameraManage.SendMessage("TriggerCrossed", this.gameObject);
        }
    }
}
