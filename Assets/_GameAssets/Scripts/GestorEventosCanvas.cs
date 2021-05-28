using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorEventosCanvas : MonoBehaviour
{
    private int points = 0;
    public Text textCounter;
    //Declaración del emisor de eventos
    public EmisorEventos emisorEventos;
    
    void Start()
    {
        //Suscripción al evento, indicando qué método está suscrito
        emisorEventos.NombreEvento += MetodoAEjecutar;
    }

    //Método suscrito
    public void MetodoAEjecutar()
    {
        points++;
        textCounter.text = points.ToString();
    }

    //Si el objeto no está activo, se elimina la suscripción
    private void OnDisable()
    {
        emisorEventos.NombreEvento -= MetodoAEjecutar;
    }

}
