using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update
    public float Vbola;
    public Rigidbody2D oRigidbody2D;

    public AudioSource somDaBola;
    void Start()
    {
        oRigidbody2D.velocity = new Vector2(Vbola, Vbola) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        somDaBola.Play();
    }
}
