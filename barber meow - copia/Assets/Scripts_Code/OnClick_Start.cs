using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class OnClick_Start : MonoBehaviour
{
  public NPCConversation myConversation;

  //Id de los item de la  barberia
  const int Tijeras_id = 1;
  const int Cuchilla_id = 2;
  const int Peine_id = 3;
  const int Secador_id = 4;
  const int Champu_id = 5;
  const int crema_afeitar_id = 6;
  const int gomina_id = 7;


  private void OnMouseOver()
  {
      
      if(Input.GetMouseButtonDown(0))
      {
          ConversationManager.Instance.StartConversation(myConversation);
      }
  }
}
