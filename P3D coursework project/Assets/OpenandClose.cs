using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenandClose : MonoBehaviour
{
    RaycastHit hit;

    

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
                
                if (hit.collider.gameObject.name.Equals("Cube"))
                {
                    gameObject.SetActive(false);
                }
            }
        }
        if (Input.GetMouseButtonUp(1))
             
        {
            gameObject.name.Equals("Cube").SetActive(true);
        }
    }
}
