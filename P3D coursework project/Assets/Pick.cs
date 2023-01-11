using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*/ Update is called once per frame
    void Update()
    {
        
    }*/
    [SerializeField] public Transform holdArea;
    private GameObject heldObj;
    private Rigidbody heldObjRB;

    [SerializeField] public float pickedupRange = 5.0f;
    [SerializeField] public float pickedupForce = 150.0f;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (heldObj == null)
            {
                RaycastHit hit;
                if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickedupRange))
                {
                    PickedupObject(hit.transform.gameObject);
                }
            }
            else
            {
                ThrowObject();
            }
        }
        if(heldObj != null)
        {
            MoveObject();
        }
    }

    public void MoveObject()
    {
        if(Vector3.Distance(heldObj.transform.position, holdArea.position) > 0.1f)
        {
            Vector3 moveDirection = (holdArea.position - heldObj.transform.position);
            heldObjRB.AddForce(moveDirection * pickedupForce);
        }
    }

    public void PickedupObject(GameObject pickObj)
    {
        if(pickObj.GetComponent<Rigidbody>())
        {
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.drag = 10;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRB.transform.parent = holdArea;
            heldObj = pickObj;
        }
    }

    public void ThrowObject()
    {
        heldObjRB.useGravity = true;
        heldObjRB.drag = 1;
        heldObjRB.constraints = RigidbodyConstraints.None;

        heldObjRB.transform.parent = null;
        heldObj = null;
    }
}
