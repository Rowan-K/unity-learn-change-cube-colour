using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(5, 7, -1);
        transform.localScale = Vector3.one * 2.5f;
        ChangeColour();
        InvokeRepeating("ChangeColour", 3.0f, 2.5f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
    
    void ChangeColour()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f), Random.Range(0.0f, 0.7f));
    }
}
