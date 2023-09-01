using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public float hýz;

    private void Start()
    {
        Destroy(gameObject, 9); //borular geldikten 9 saniye sonra yok et.
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * hýz * Time.deltaTime;

    }
}
