using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Rigidbody rb;
    public float rapidezDesplazamiento = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento * Time.deltaTime;
        float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento * Time.deltaTime;

        transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);

        
    }
}
