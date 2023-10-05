using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIMITA: MonoBehaviour
{
   public float velPersonaje;
   public float velGiro;
   public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        Vector3 direccion = new Vector3(h,0,v);

        transform.Translate(direccion * velPersonaje * Time.deltaTime, Space.World);

        if(direccion != Vector3.zero)
        {
            Quaternion rota = Quaternion.LookRotation(direccion, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation,rota,velGiro);
            
            // aca el mono se mueve
            anim.SetBool("RUN",true);
        }
        else
        {
        anim.SetBool("RUN",false);
        }
    }
}
