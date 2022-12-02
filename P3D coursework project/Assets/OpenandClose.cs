using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenandClose : MonoBehaviour
{
    RaycastHit hit;

    private bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
             
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                
                if (isOpen.Equals(false) && hit.collider.gameObject.name.Equals("Door"))
                {
                    transform.rotation = Quaternion.Euler(0.0f, 0f, 0.0f);
                    transform.position = new Vector3(0.73f, 1.5f, 2.06f);
                    isOpen = true;
                }
                else if (hit.collider.gameObject.name.Equals("Door") && isOpen.Equals(true))
                {
                    transform.rotation = Quaternion.Euler(0.0f, 90f, 0.0f);
                    transform.position = new Vector3(1.43f, 1.5f, 1.33f);
                    isOpen = false;
                }
            }
        }
    }
}
