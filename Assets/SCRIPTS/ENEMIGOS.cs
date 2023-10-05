using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ENEMIGOS : MonoBehaviour
{
  public STATS est;
    void Start()
    {
        est= GetComponent<STATS>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("ENEMIGO_N1"))
        {
            est.vidaHero = est.vidaHero -1;
            est.mostrarVidas();
        }
    }
}
