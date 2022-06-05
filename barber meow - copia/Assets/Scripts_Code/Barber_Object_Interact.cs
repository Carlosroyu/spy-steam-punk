using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Barber_Object_Interact : MonoBehaviour
{

    public int barber_id; 
    private Vector3 objScale;
    private AudioSource clickSound;
  
  void Awake(){
    objScale = this.transform.localScale;
    clickSound = GameObject.Find("UI_sound_click").GetComponent<AudioSource>();
  }

  private void OnMouseOver()
  {
      this.transform.localScale = new Vector3(objScale.x + .1f,objScale.y + .1f,objScale.z + .1f);
      if(Input.GetMouseButtonDown(0))
      {
        clickSound.Play();
         ConversationManager.Instance.SetInt("Barber_Item_ID", barber_id);
      }
  }
  private void OnMouseExit()
  {
    this.transform.localScale = objScale;
  }
}