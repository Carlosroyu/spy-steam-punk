using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Xnode;

public class NewBehaviourScript : MonoBehaviour
{
    public DialogueGraph graph;
    Coroutine _parser;
    public Text speaker;
    public Text dialogue;
    public Image speakerImage;



    private void Start() 
    {
        foreach ( BaseNode b in graph.nodes)
        {
            if (b.GetString() ="Start")
            {
               //Make this node an starting point
               graph.current = b;
               break;
            }
        }
        
        _parser =StartCoroutine(ParseNode());
    }


    IEnumerator ParseNode()
    {
        BaseNode b = graph.current;
        string data = b.GetString();
        string[] dataParts = data.Split('/');

        if(dataParts[0] == "DialogueNode")
        {
            //Run dialogue processing
            speaker.text = dataParts[1]; //el uno porque es la posicion en la muestra del nodo de dialogo
            dialogue.text = dataParts[2];//el dos porque es la posicion en la muestra del nodo de dialogo
            speakerImage.sprite = b.GetSprite();
            yield return new WaitUntil(() => Input.GetMouseButttonDown(0));
            yield return new WaitUntil(() => Input.GetMouseButttonUp(0));
            NextNode("exit");

        }
    }


    public void NextNode(string FdieldName)
    {
        //Find the port whith this name;

        if(_parser != null)
        {
            StopCoroutine(_parser);
            _parser = null;
        }

        foreach (NodePort p in graph.current.Ports)
        {

            if(p.FdieldName == FdieldName)
            {
                graph.current = p.conection.node as BaseNode;
                break;
            }
            
        }

        _parser = StartCoroutine(ParseNode());



    }

}
