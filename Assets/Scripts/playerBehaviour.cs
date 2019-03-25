using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{
    public float speed;
    public static bool movimento;

    private bool zoom = false;
    public bool qte = false;

    public float xmax = 9.43f;
    public float ymax = 9.04f;
    public float ymin;
    private float movimentoEixoX;
    private float movimentoEixoY;
    private float zoomSize = 5;

    void Start()
    {
        movimento = true;
    }

    void Update()
    {
        Movimentacao();
        Limite();
        quickTimeEvent();
    }

    void Movimentacao()
    {
        movimentoEixoX = Input.GetAxis("Horizontal");
        movimentoEixoY = Input.GetAxis("Vertical");
        if (movimento)
        {
            transform.Translate(Vector3.right * movimentoEixoX * speed * Time.deltaTime);
            transform.Translate(Vector3.up * movimentoEixoY * speed * Time.deltaTime);
        }
    }
    void Limite()
    {
        if (transform.position.x < xmax)
        {
            transform.position = new Vector3(xmax, transform.position.y);
        }
        else if (transform.position.x > -xmax)
        {
            transform.position = new Vector3(-xmax, transform.position.y);
        }
        if (transform.position.y > ymax)
        {
            transform.position = new Vector3(transform.position.x, ymax);
        }
        if (transform.position.y < -ymax)
        {
            transform.position = new Vector3(transform.position.x, -ymax);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "qte")
        {
            qte = true;
        }
    }
    void quickTimeEvent()
    {
        if (qte)
        {
            speed = 0;
            Cenario.Cspeed = -2;
            comportamentoCamera.speed = 2;
            GetComponent<Camera>().orthographicSize = zoomSize;
            zoom = true;
        }
    }
}
 