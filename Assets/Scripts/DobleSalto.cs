using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobleSalto : MonoBehaviour
{
    public Rigidbody rb;
    public float saltoVel;
    private bool enElSuelo = true;
    public int maxSaltos = 4;
    public int saltoActual = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && (enElSuelo || maxSaltos > saltoActual))
        {
            rb.velocity = new Vector3(0f, saltoVel, 0f * Time.deltaTime);
            rb.AddForce(Vector3.up * saltoVel, ForceMode.Impulse);
            enElSuelo = false;
            saltoActual++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        enElSuelo = true;
        saltoActual = 0;
    }


}
