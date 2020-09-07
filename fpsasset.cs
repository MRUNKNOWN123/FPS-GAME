using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsasset : MonoBehaviour
{
    Rect fpsRect;
    GUIStyle style;

    //float fps = 1/Time.deltaTime;
    // Start is called before the first frame update
    void Start()
    {
        fpsRect = new Rect(30,30,400,100);
        style = new GUIStyle();
        style.fontSize = 30;

        //StartCoroutine(RecalculateFPS());

    }

    /*private IEnumerator RecalculateFPS()
    {
        

        while(true)
        {
            
            //float fps = 1/Time.deltaTime;
            yield return new WaitForSeconds(1);
        }
    }*/

    void OnGUI()
    {
        float fps = 1/Time.deltaTime;
        GUI.Label(fpsRect, "FPS: " + string.Format("{0:0}", fps), style);
    }
}
