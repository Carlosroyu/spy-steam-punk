using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Animation : MonoBehaviour
{

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
   public void Activar_Corte_Pelo()
   {
       anim.SetBool("Corte_Anim", true);
       anim.SetBool("Idle_Anim", false);
   }
   public void Activar_Idea_Pelo()
   {
       anim.SetBool("Idea_Anim", true);
       anim.SetBool("Corte_Anim", false);
   }

   public void Activar_Pensando_Pelo()
   {
       anim.SetBool("Idle_Anim", true);
       anim.SetBool("Idea_Anim", false);
   }

    
}
