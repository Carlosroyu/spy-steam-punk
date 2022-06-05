using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlloyAnimations : MonoBehaviour
{
    const float BadHairCut = 0.0f;
    const float ConMelenaContento = 0.1f;
    const float SinMelenaContento = 0.2f;
    const float SinMelenaHablando = 0.3f;
    const float ConMelenaHablando = 0.4f;
    const float SinMelenaNeutro = 0.5f;
    const float ConMelenaNeutro = 0.6f;
    const float SinMelenaPreocupao = 0.7f;
    const float ConMelenaPreocupao = 0.8f;

    Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        anim["Alloy_Expresions"].speed = 0.0f; //["Alloy_Expresions"]
        changeAnimation(ConMelenaPreocupao);
    }

    void changeAnimation(float time){
        anim["Alloy_Expresions"].time = time;
    }
    
}
