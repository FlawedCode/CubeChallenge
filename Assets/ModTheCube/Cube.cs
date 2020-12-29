using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float scaleFactor = 1.0f;
    public float scaleIncrease = 0.01f;

    public float redValue = 0.1f;
    public float greenValue = 0.1f;
    public float blueValue = 0.1f;


    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        RotateCube();
        ScaleCube();
        ChangeColor();

    }

    void ScaleCube()
    {
        transform.localScale = Vector3.one * scaleFactor;
        scaleFactor = scaleFactor + scaleIncrease;
        if (scaleFactor >= 6)
        {
            scaleFactor = 1;
        }
    }

    void RotateCube()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.2f, 0.2f);
    }

    void ChangeColor()
    {
        redValue = (Random.Range(0.1f, 1f));
        greenValue = (Random.Range(0.1f, 1.0f));
        blueValue = (Random.Range(0.1f, 1.0f));


        Material material = Renderer.material;
        material.color = new Color(redValue, greenValue, blueValue, 0.4f);

    }
}
