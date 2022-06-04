using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Animation : MonoBehaviour
{

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
   public void Activar_Corte_Pelo()
   {
       anim.Play("Corte_Anim");
   }

    
}
