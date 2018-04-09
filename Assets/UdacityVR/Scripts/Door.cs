using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
    public bool locked;
    // Create a boolean value called "opening" that can be checked in Update() 
    public bool opening;
    //public bool yesKey;
    public AudioSource doorSource;
    public AudioClip [] soundFiles;

    void Start()
    {
        locked = true;
        opening = false;
        Debug.Log("start" + locked);
    } 
    void Update() {
            // If the door is opening and it is not fully raised
            // Animate the door raising up
            if (opening == true)
            {
                if (transform.position.y <= 8.4f)
                { transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World); }
            } 
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        //if(yesKey == true)
        locked = false;
    }

    public void OnDoorClicked()
    {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        {
            if (locked == false)
            {
                opening = true;
                doorSource.clip = soundFiles[1];
                doorSource.Play();
            }
            // (optionally) Else
            // Play a sound to indicate the door is locked
            else
            {
                doorSource.clip = soundFiles[0];
                doorSource.Play();
            }
        }
    }
}
