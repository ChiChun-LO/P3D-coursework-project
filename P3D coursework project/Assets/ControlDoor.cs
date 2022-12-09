using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDoor : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private string playerTag;
    [SerializeField] private bool open = false;
    [SerializeField] private bool close = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("A");
        if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E");
            }
        if(other.tag == "Player")
        {
Debug.Log("B");
        if(/*(Input.GetKeyDown(KeyCode.E)) &&*/ open)
        {
            Debug.Log("C");
            //myDoor.Play("OpenDoor", 0, 0.0f);
            //gameObject.SetActive(false);
            
        }

        else if(/*(Input.GetKeyDown(KeyCode.E)) &&*/ close)
        {
            myDoor.Play("CloseDoor", 0, 0.0f);
            gameObject.SetActive(false);
        }
        }
    }


    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("E");
        }
    }
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