using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoCamera : MonoBehaviour
{
    public float speed;
    public GameObject personagem;
    float posicaoPersonagem;
    float variavel;
    void Start()
    {
        posicaoPersonagem = personagem.transform.position.y;
    }
    /// <summary>
    /// A camera acompanha o movimento do personagem no eixo Y
    /// </summary>
    void Update()
    {
        variavel = Input.GetAxis("Vertical");
      if (personagem.transform.position.y != posicaoPersonagem)
        {
            transform.Translate(Vector3.up * variavel * speed * Time.deltaTime);
        }

    }
}
