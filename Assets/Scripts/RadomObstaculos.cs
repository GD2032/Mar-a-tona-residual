using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomObstaculos : MonoBehaviour
{
    public float tempocorrido = 0;
    public float proximoSpawn;
    public GameObject[] lixos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= tempocorrido)
        {
            tempocorrido = Time.time + proximoSpawn;
            Vector2 position = new Vector2(14, Random.Range(2, -4.89f));
            Instantiate(lixos[1], position, Quaternion.identity);

        }
    }


} 
  