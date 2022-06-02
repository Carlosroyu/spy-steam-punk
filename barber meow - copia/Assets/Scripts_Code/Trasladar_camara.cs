using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Trasladar_camara : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 gameCamera_Transition_Offset;
    private float frame;
    public float frameCounter;
    public GameObject gameCamera;

    private void Awake() {
        gameCamera_Transition_Offset = new Vector3(2.5f,0,0);
        frame = 0f;
    }

    // Update is called once per frame
    public void MovegameCameraCat()
    {
        var targetPosition = gameCamera.transform.position + gameCamera_Transition_Offset;
        var initPosition = gameCamera.transform.position;
        frame = 0f;
        StartCoroutine(MovegameCamera(initPosition, targetPosition));
    }
    public void MovegameCameraClient()
    {
        var targetPosition = gameCamera.transform.position - gameCamera_Transition_Offset;
        var initPosition = gameCamera.transform.position;
        frame = 0f;
        StartCoroutine(MovegameCamera(initPosition, targetPosition));
    }

    private IEnumerator MovegameCamera(Vector3 initPosition, Vector3 targetPosition){
        while(frame/frameCounter < 1){
            gameCamera.transform.position = Vector3.Lerp(initPosition, targetPosition, frame/frameCounter);
            frame++;
            yield return frame;
            yield return gameCamera;
        }
        yield return null;
        
    }
}
