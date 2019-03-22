using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerBehaviour : MonoBehaviour
{
    public float speed;
    public static bool movimento;

    public float xmax;
    public Text scoreTeste;
    public float score;
    public float ymax;

    public float movimentoEixoX;
    public float movimentoEixoY;

    void Start()
    {
        movimento = true;
        
    }

    void Update()
    {score += Time.deltaTime * speed;

        movimentacao();
        
    }

    void movimentacao()
    {
        movimentoEixoX = Input.GetAxis("Horizontal");
        movimentoEixoY = Input.GetAxis("Vertical");
        if (movimento)
        { scoreTeste.text = score.ToString();
            transform.Translate(Vector3.right * movimentoEixoX * speed * Time.deltaTime);
            transform.Translate(Vector3.up * movimentoEixoY * speed * Time.deltaTime);
           
        }
    }
}
