using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject lastGround;
    [SerializeField] private GameObject groundPrefab;
    private GameObject newGround;
    private int groundDirection;
    void Start()
    {
        GenerateRandomGround();
    }

    public void GenerateRandomGround()
    {
        for(int i = 0; i < 70; i++)
        {
            CreateNewGround();
        }
    }
    private void CreateNewGround()
    {
        groundDirection = Random.Range(0, 2);
        if(groundDirection == 0)
        {
            newGround = Instantiate(groundPrefab, new Vector3(lastGround.transform.position.x - 1f, lastGround.transform.position.y,lastGround.transform.position.z),Quaternion.identity);
            lastGround = newGround;
        }
        else
        {
            newGround = Instantiate(groundPrefab, new Vector3(lastGround.transform.position.x, lastGround.transform.position.y, lastGround.transform.position.z +1f), Quaternion.identity);
            lastGround = newGround;
        }
    }
}
