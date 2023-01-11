using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPoint : MonoBehaviour
{
    [SerializeField] private string playerTag;

    private static Vector3 playerRecordPoint;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {
            playerRecordPoint = this.transform.position;
        }
    }
    
    public static Vector3 Get_playerRecordPoint()
    {
        return playerRecordPoint;
    }
}
