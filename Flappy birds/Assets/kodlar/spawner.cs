using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour //borularýn ortaya çýkmasý
{

    public birdy BirdScript;
    public GameObject Borular;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }


    public IEnumerator SpawnObject(float time)//Süreli þeyleri kullanabiliriz.
    {
        while (!BirdScript.isDead) //kuþ ölmediyse ,
        {

            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity); // Borular bunlar arasýnda random yükseklikte gelsin
            yield return new WaitForSeconds(time); //1 saniye bekle. Yani borular 1 saniye arayla gelsin.
        }
    }

}
