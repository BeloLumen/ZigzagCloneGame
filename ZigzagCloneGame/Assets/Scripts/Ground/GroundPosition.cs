using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPosition : MonoBehaviour
{
    private GroundSpawn groundSpawnController;
    private Rigidbody rb;
    [SerializeField] private float endY;
    private int groundDirection;
    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawn>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckYPosition();
    }
    private void CheckYPosition()
    {
        if(transform.position.y <= endY)
        {
            setRigidbodyValues();
            setGroundPosition();
        }
    }
    private void setRigidbodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
    private void setGroundPosition()
    {
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            transform.position = new Vector3(groundSpawnController.lastGround.transform.position.x - 1f, groundSpawnController.lastGround.transform.position.y, groundSpawnController.lastGround.transform.position.z);

        }
        else
        {
            transform.position = new Vector3(groundSpawnController.lastGround.transform.position.x, groundSpawnController.lastGround.transform.position.y, groundSpawnController.lastGround.transform.position.z+1f);
        }

        groundSpawnController.lastGround = gameObject;
    }
}
