using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{
    public float speed;
    public static bool movimento;

    public float xmax;
    public float ymax;

    public float movimentoEixoX;
    public float movimentoEixoY;

    void Start()
    {
        movimento = true;
    }

    void Update()
    {
        movimentacao();
    }

    void movimentacao()
    {
        movimentoEixoX = Input.GetAxis("Horizontal");
        movimentoEixoY = Input.GetAxis("Vertical");
        if (movimento)
        {
            transform.Translate(Vector3.right * movimentoEixoX * speed * Time.deltaTime);
            transform.Translate(Vector3.up * movimentoEixoY * speed * Time.deltaTime);
        }
    }
}
