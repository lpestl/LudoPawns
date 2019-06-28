using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
#if UNITY_ANDROID || UNITY_IOS
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            var touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            //Debug.Log("TScreen: " + touch.position + " TWorld: " + touchPos);
            EchoLog.Print("TScreen: " + touch.position + " TWorld: " + touchPos);
        }
#endif

#if UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            var mousePosition = Input.mousePosition;
            var mousePos = Camera.main.ScreenToWorldPoint(mousePosition);

            //Debug.Log("MScreen: " + mousePosition + " MWorld: " + mousePos);
            EchoLog.Print("MScreen: " + mousePosition + " MWorld: " + mousePos);
        }
#endif
    }
}
