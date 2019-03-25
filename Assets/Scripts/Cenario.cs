using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    public static float Cspeed = -6;
    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Cspeed, 0);
    }
}
