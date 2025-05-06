using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionLava : MonoBehaviour
{
    public float velocidadX = 0.2f;
    public float velocidadY = 0.1f;
    public int indiceMaterialLava = 0; 

    private Renderer rend;
    private Material lavaMaterial;

    void Start()
    {
        rend = GetComponent<Renderer>();

       
        lavaMaterial = rend.materials[indiceMaterialLava];
    }

    void Update()
    {
        float offsetX = Time.time * velocidadX;
        float offsetY = Time.time * velocidadY;

        lavaMaterial.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
