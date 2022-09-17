using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private BallDataTransmitter ballDataTransmitter;

    [SerializeField] private float ballMoveSpeed;

    private void Update()
    {
        setBallMovement();
    }

    private void setBallMovement()
    {
        transform.position += ballDataTransmitter.getBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
