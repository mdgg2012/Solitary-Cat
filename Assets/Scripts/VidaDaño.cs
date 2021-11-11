using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDaño : MonoBehaviour
{
    public int vida = 100;
    public bool invencible = false;
    public float tiempo_invencible = 1f;

    public void RestarVida(int cantidad)
    {
        if (!invencible && vida > 0)
        {
            vida = cantidad;
            StartCoroutine(Invulnerabilidad());
        }
    }
     
    IEnumerator Invulnerabilidad()
    {
        invencible = true;
        yield return new WaitForSeconds(tiempo_invencible);
        invencible = false;
    }
}
