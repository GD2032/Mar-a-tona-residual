using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obstaculos;
    public Transform pontoDeGeração;
    public float DistanciaEntre;
    public float LarguradeObstaculo;
    // Start is called before the first frame update
    void Start()
    {
        LarguradeObstaculo = obstaculos.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < pontoDeGeração.position.x)
        {
            transform.position = new Vector3(transform.position.x + LarguradeObstaculo + DistanciaEntre, transform.position.y, transform.position.z);
            Instantiate(obstaculos, transform.position, transform.rotation);
        }
    }
}
