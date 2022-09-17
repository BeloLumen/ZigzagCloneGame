using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;
    [SerializeField] private Color[] groundColors;
    private int colorIndex=0;
    [SerializeField] private float lerpValue;
    private float currenTime;
    [SerializeField] float time;

    // Update is called once per frame
    void Update()
    {
        ColorChangeTime();
        ChangeGroundColor();

    }
    private void ColorChangeTime()
    {
        if(currenTime <= 0)
        {
            CheckColorIndex();
            currenTime = time;
            
        }
        else
        {
            currenTime -= Time.deltaTime;
        }

    }
    private void CheckColorIndex()
    {
        colorIndex++;
        if (colorIndex >= groundColors.Length)
        {
            colorIndex = 0;
        }
    }
    private void ChangeGroundColor()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, groundColors[colorIndex],lerpValue * Time.deltaTime);
    }
    private void OnDestroy()
    {
        groundMaterial.color = groundColors[0];
    }
}
