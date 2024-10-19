using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementHandler : MonoBehaviour
{
    public InputHandler inputHandler;
    [SerializeField] private float ballSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        if (inputHandler == null) Debug.LogError("input handler не назначен");
    }

    private void MoveBall()
    {
        if (inputHandler.IsThereTouchOnScreen())
        {
            Vector2 currDeltaPos = inputHandler.GetTouchDeltaPosition();
            currDeltaPos = currDeltaPos * ballSpeed;
            Vector3 newGravityVector = new Vector3(currDeltaPos.x, Physics.gravity.y, currDeltaPos.y);
            Physics.gravity = newGravityVector;

        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }
}