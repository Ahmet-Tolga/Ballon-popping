using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rgb;
    public float speed;
    void Start()
    {
        rgb=GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        rgb.velocity=new Vector2(Input.GetAxisRaw("Horizontal")*speed*Time.deltaTime,0f);
    }
}
