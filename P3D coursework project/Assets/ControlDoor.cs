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

        if(/*Input.GetMouseButtonUp(0) &&*/ open)
        {
            myLeftDoor.Play("OpenDoor", 0, 0.0f);
            myRightDoor.Play("OpenDoor 1", 0, 0.0f);
            gameObject.SetActive(false);
            
        }

        else if(/*Input.GetMouseButtonUp(0) &&*/ close)
        {
            myLeftDoor.Play("CloseDoor", 0, 0.0f);
            myRightDoor.Play("CloseDoor 1", 0, 0.0f);
            gameObject.SetActive(false);
        }
        }
    }


    /*void Update()d
    {
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("E");
        }
    }*/
}
    /*private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Exiting here");
        if (other.tag == playerTag)
        {
            inTrigger = false;
            animator.SetTrigger(hibernateTrigger);
        }
    }*/
/*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E");
            }
    }
}}*/