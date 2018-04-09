using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public GameObject door;
    //static bool keyCollected;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Object.Instantiate(keyPoof, transform.position, Quaternion.Euler(-990f, 0, 0));
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        //keyCollected = true;
        door.GetComponent<Door>().Unlock();
        //door.Unlock();
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);    

    }

}
