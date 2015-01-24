using UnityEngine;
using System.Collections;

public class ClickPickup : MonoBehaviour {
    PlayerAI playerAI;
    CameraManagement cameraManage;
    Camera currCamera;
    LayerMask pickUp;
	// Use this for initialization
	void Start () {
        playerAI = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAI>();
        cameraManage = GameObject.FindGameObjectWithTag("CameraManagement").GetComponent<CameraManagement>();
        pickUp = LayerMask.GetMask("PickUp");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            currCamera = cameraManage.getCurrCamera();
            RaycastHit hit;
            Ray camRay = currCamera.ScreenPointToRay (Input.mousePosition);
            if (Physics.Raycast(camRay, out hit, 100, pickUp))
            {
                Debug.Log("Item Hit");
                if (playerAI.addItem(hit.collider.gameObject))
                {
                    hit.collider.gameObject.SetActive(false);
                }
                else 
                {
                    Debug.Log("Failed to add item");
                }
            }
            Debug.DrawRay(camRay.origin, camRay.direction *100, Color.green);
        }
	}

}
