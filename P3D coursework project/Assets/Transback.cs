using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transback : MonoBehaviour
{
    [SerializeField] private string playerTag;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log(GameObject.FindWithTag("Player").transform.position);
            GameObject.FindWithTag("Player").transform.position = RecordPoint.Get_playerRecordPoint();
        }
    }
    
}
