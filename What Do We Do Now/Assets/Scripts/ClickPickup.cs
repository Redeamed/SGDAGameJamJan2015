using UnityEngine;
using System.Collections;

public class ClickPickup : MonoBehaviour {
    GameObject player;
    PlayerAI playerAI;

    CameraManagement cameraManage;
    Camera currCamera;
    LayerMask pickUp;
    
    LayerMask NPCMask;
    GameObject npc;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerAI = player.GetComponent<PlayerAI>();
        cameraManage = GameObject.FindGameObjectWithTag("CameraManagement").GetComponent<CameraManagement>();
        pickUp = LayerMask.GetMask("Pickup");
        NPCMask = LayerMask.GetMask("NPC");
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            currCamera = cameraManage.getCurrCamera();
            RaycastHit hit;
            Ray camRay = currCamera.ScreenPointToRay (Input.mousePosition);

            if (Physics.Raycast(camRay, out hit, Mathf.Infinity, pickUp))
            {

                Debug.Log("test");
                if (playerAI.addItem(hit.collider.gameObject))
                {
                    hit.collider.gameObject.SetActive(false);
                }

                Debug.Log(hit.transform.name);

            }
            else if (Physics.Raycast(camRay, out hit, Mathf.Infinity, NPCMask))
            {

                npc = hit.transform.gameObject;
                NPCManager.singleton.activeNPC = npc;
                Debug.Log(hit.transform.name);

            }
            Debug.DrawRay(camRay.origin, camRay.direction * 100.0f, Color.green);
        }
	}

}
