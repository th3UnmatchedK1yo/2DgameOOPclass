using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarllingBG : MonoBehaviour
{
    public Vector2 speed = Vector2.zero;
    private Vector2 offset = Vector2.zero;
    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
        
    }

    
    void Update()
    {
        offset += speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", offset);
    }
}
