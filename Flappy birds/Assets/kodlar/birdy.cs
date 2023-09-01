using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager gm;
    public GameObject DeathScreen;//�l�m ekran�

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        //t�klamay� al
        if (Input.GetMouseButton(0))
        {
            //havada ku�u s��rat.
            rb2D.velocity = Vector2.up * velocity;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Score Area")
        {
            gm.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//�l�m 
    {
        if(collision.gameObject.tag == "Death Area")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);//�l�m ekran�n� aktif eder.
        }
    }
}
