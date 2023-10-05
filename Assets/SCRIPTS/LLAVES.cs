using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLAVES : MonoBehaviour
{
    public Light luzLlavesAmarilla;
    void Start()
    {
      luzLlavesAmarilla.enabled = false;  
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            luzLlavesAmarilla.enabled = true;
            Debug.Log("alguien entro el player");
        }


    }
    void OnTriggerStay()
    {
        Debug.Log("alguien esta ahí");
    }
    void OnTriggerExit()
    {
        Debug.Log("alguien salió");
    }
}
