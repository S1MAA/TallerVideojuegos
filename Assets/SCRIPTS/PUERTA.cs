using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUERTA : MonoBehaviour
{
    public Light llaveAmarilla;
    public Light llaveAzul;
    public Light llaveVerde;
    public Animator animPuerta;

    void Start()
    {
        animPuerta = GameObject.Find("PUERTA").GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (llaveAmarilla.enabled == true && llaveAzul.enabled == true && llaveVerde.enabled == true && col.gameObject.CompareTag("Player"))
        {
            animPuerta.SetBool("PUERTA_OPEN", true);
        }
    }

}
