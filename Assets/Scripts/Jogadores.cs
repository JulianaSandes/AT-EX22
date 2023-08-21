using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{
    // Start is called before the first frame update
    public float Vjogador;
    public bool Jogador1;
    public bool Jogador2;
    public bool Jogador3;
    public bool Jogador4;

    public float yMinimo;
    public float yMaximo;
    public float xMinimo;
    public float xMaximo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Jogador1 == true)
        {
            Mjogador1();
        }

        if(Jogador2 == true)
        {
            Mjogador2();
        }

        if(Jogador3 == true)
        {
            Mjogador3();
        }

        if(Jogador4 == true)
        {
            Mjogador4();
        }
    }

    //metodos proprios
    public void Mjogador1()
    {
        //transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Vjogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Vjogador * Time.deltaTime);
        }

    }

    public void Mjogador2()
    {

       // transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Vjogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Vjogador * Time.deltaTime);
        }
    }

    public void Mjogador3()
    {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Vjogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Vjogador * Time.deltaTime);
        }
    }

    public void Mjogador4()
    {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), Mathf.Clamp(transform.position.y, xMinimo, yMaximo));

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Vjogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Vjogador * Time.deltaTime);
        }
    }
}
