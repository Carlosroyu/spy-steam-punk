using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Barber_Object_Interact : MonoBehaviour
{

    public int barber_id; 

  private void OnMouseOver()
  {

      if(Input.GetMouseButtonDown(0))
      {
         ConversationManager.Instance.SetInt("Barber_Item_ID", barber_id);
      }

  }
}