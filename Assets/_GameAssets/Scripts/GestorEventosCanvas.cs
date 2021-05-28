using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorEventosCanvas : MonoBehaviour
{
    private int points = 0;
    public Text textCounter;
    //Declaraci�n del emisor de eventos
    public EmisorEventos emisorEventos;
    
    void Start()
    {
        //Suscripci�n al evento, indicando qu� m�todo est� suscrito
        emisorEventos.NombreEvento += MetodoAEjecutar;
    }

    //M�todo suscrito
    public void MetodoAEjecutar()
    {
        points++;
        textCounter.text = points.ToString();
    }

    //Si el objeto no est� activo, se elimina la suscripci�n
    private void OnDisable()
    {
        emisorEventos.NombreEvento -= MetodoAEjecutar;
    }

}
