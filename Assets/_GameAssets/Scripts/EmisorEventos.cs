using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmisorEventos : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;

    public delegate void MetodoDelegado();//El método delegado será el método suscrito
    public event MetodoDelegado NombreEvento;//El nombre del evento es el evento al que te suscribes. Tiene la lista de métodos suscritos.

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = transform.forward * speed;
        } else
        {
            rb.velocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            //LANZAMIENTO EVENTO
            if (NombreEvento != null) //Evalua si hay algún método suscrito y lanza el evento
                NombreEvento();
            //FIN LANZAMIENTO EVENTO
            Destroy(other.gameObject);
        }
    }

}
