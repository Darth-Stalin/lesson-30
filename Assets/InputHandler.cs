using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 GetTouchDeltaPosition()
    {
        if (Input.touchCount>0)
        {
            return Input.GetTouch(0).deltaPosition;
        }
        return Vector2.zero;
    }

    public bool IsThereTouchOnScreen()
    {
        if (Input.touchCount>0) return true;
        else return false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
