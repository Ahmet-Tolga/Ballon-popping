using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ballon_motion : MonoBehaviour
{
    Rigidbody2D rgb;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rgb.velocity = new Vector2(0f, -2f);
    }
}
