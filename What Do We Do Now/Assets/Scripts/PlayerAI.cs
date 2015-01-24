using UnityEngine;
using System.Collections;

public class PlayerAI : MonoBehaviour {
    GameObject[] items;
	// Use this for initialization
	void Start () 
    {
	    items = new GameObject[9];
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    public bool addItem(GameObject item)
    {
        bool success = false;
        for(int i = 0; i  < 9; ++i )
        {
            if(items[i] == null)
            {
                items[i] = item;
                success = true;
                Debug.Log("Item added: " + item.name);
                break;
            }
        }
        return success;
    }

    public bool removeItem(GameObject item)
    {
        bool success = false;
        for(int i = 0; i  < 9; ++i )
        {
            if(items[i] == item)
            {
                items[i] = null;
                success = true;
            }
        }
        return success;
    }
}
