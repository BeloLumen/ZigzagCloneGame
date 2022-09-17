using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFall groundFallController;

    public void SetGroundRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidbodyValues());
    }
}
