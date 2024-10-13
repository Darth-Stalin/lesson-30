using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private float startTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
/*         if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startTimer = Time.time;
                Debug.Log("Tan!");
            }
            if (touch.phase == TouchPhase.Ended && Time.time - startTimer>2f)
            {
                Debug.Log("Длинный тап");
            }
        } */

/*         for (int i = 0; i < Input.touches.Length; i++)
        {
            Debug.Log("Это касание номер"+ i + " с позицией " + Input.touches[i].position);
        } */

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.deltaPosition.x > 0) Debug.Log("Right");
            if (touch.deltaPosition.x < 0) Debug.Log("Left");
        }
    }
}
