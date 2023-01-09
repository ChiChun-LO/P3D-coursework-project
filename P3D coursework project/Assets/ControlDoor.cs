using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDoor : MonoBehaviour
{
    [SerializeField] private Animator myLeftDoor = null;
    [SerializeField] private Animator myRightDoor = null;
    [SerializeField] private string playerTag;
    [SerializeField] private bool open = false;
    [SerializeField] private bool close = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {
            if(open)
            {
                myLeftDoor.Play("OpenDoor", 0, 0.0f);
                myRightDoor.Play("OpenDoor 1", 0, 0.0f);
                gameObject.SetActive(false);
            
            }

            else if(close)
            {
                myLeftDoor.Play("CloseDoor", 0, 0.0f);
                myRightDoor.Play("CloseDoor 1", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}