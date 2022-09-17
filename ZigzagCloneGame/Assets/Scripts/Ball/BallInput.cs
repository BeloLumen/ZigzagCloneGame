using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInput : MonoBehaviour
{
    public Vector3 ballDirection;
    // Start is called before the first frame update
    void Start()
    {
        ballDirection = Vector3.left;
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleBallInput();
    }
    private void HandleBallInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeDirection();
        }
    }
    private void ChangeDirection()
    {
        if(ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }
}
