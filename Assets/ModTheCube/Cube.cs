using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float startDelay = 2f;// Delay before the first color change
    void Start()
    {
        transform.position = new Vector3(2, 2, 1);
        transform.localScale = Vector3.one * 2f;

        Material material = Renderer.material;

        material.color = new Color(1.0f, 1.0f, 0.5f, 1.0f);

        Invoke(nameof(ChangeColor), startDelay);
    }

    void Update()
    {
        transform.Rotate(0.0f, 0.0f, 10.0f * Time.deltaTime);
    }

    void ChangeColor()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.1f, 2.0f));
        
        Invoke(nameof(ChangeColor), Random.Range(1f, 3f));
    }
}
