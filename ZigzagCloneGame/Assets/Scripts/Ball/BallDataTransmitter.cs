using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmitter : MonoBehaviour
{
    [SerializeField] private BallInput ballInput;
    
    
    public Vector3 getBallDirection()
    {
        return ballInput.ballDirection;
    }
}
