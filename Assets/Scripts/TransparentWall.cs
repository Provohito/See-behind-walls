using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentWall : MonoBehaviour
{
    private Renderer rend;
    private Color materialColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        materialColor = rend.material.color;
    }

    public void ChangeTransparency(bool transparent)
    {
        //if (this.transparent == transparent) return;

        if (transparent)
        {
            materialColor.a = 0.3f;
        }
        else
        {
            materialColor.a = 1f;
        }

        rend.material.color = materialColor;
    }
}
