using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionLava : MonoBehaviour
{
    public float scrollX = 0.1f;
    public float scrollY = 0.1f;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offsetX = Time.time * scrollX;
        float offsetY = Time.time * scrollY;
        rend.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
