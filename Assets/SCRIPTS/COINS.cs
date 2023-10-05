using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COINS : MonoBehaviour
{
      public STATS est;
   
    void Start()
    {
      est= GetComponent<STATS>();
   
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("COIN_1"))
        {
            est.coins = est.coins +1;
            est.mostrarCoins();
          
        }
    }


}
