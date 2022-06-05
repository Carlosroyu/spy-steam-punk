using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlloyAnimations : MonoBehaviour
{
    //Diccionario personal para saber a que corresponde cada indice de la jerarquia
    /*const int alloy_neutro = 0;
    const int alloy_badhaircut = 1;
    const int alloy_feliz_melena = 2;
    const int alloy_goodhaircut = 3;
    const int alloy_habla = 4;
    const int alloy_habla_melena = 5;
    const int alloy_neutro_melena = 6;
    const int alloy_triste = 7;
    const int alloy_triste_melena = 8;*/

    Transform[] Alloy_Expresions;
    
    void Start()
    {
        Alloy_Expresions = new Transform[this.transform.childCount];
        for(var i = 0; i < this.transform.childCount; i++){
            Alloy_Expresions[i] = this.transform.GetChild(i);
        }
    }

    public void clearSprite(){
        for(var i = 0; i < this.transform.childCount; i++){
            Alloy_Expresions[i].gameObject.SetActive(false);
        }
    }
    public void selectSprite(int selection){
        clearSprite();
        Alloy_Expresions[selection].gameObject.SetActive(true);
    }
    
}
