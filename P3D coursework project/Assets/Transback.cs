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
            GameObject.FindGameObjectWithTag("Player").transform.position = RecordPoint.Get_playerRecordPoint();
        }
    }
    
}
