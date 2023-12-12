using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTexto : MonoBehaviour
{
    public Text textoContador;
    public Temporizador temporizador; // Referencia al script del temporizador
    public string[] mensajesOleadas = { "Oleada 1", "Oleada 2", "Oleada Final" };
    public float[] tiemposMostrarTexto = { 60f, 40f, 20f };
    public float duracionTexto = 2f;

    private void Start()
    {
        // Inicia la rutina para mostrar el texto en los momentos espec�ficos
        StartCoroutine(MostrarTextoEnMomentosEspecificos());
    }

    IEnumerator MostrarTextoEnMomentosEspecificos()
    {
        for (int i = 0; i < mensajesOleadas.Length; i++)
        {
            // Espera hasta que el tiempo alcance el valor espec�fico
            yield return new WaitUntil(() => Mathf.FloorToInt(tiemposMostrarTexto[i]) == Mathf.FloorToInt(temporizador.tiempoRes));

            // Muestra el texto correspondiente a la oleada
            MostrarTexto(mensajesOleadas[i]);

            // Espera durante la duraci�n especificada antes de desactivar el texto
            yield return new WaitForSeconds(duracionTexto);

            // Desactiva el texto
            DesactivarTexto();
        }
    }

    void MostrarTexto(string mensaje)
    {
        // Aseg�rate de que el objeto de texto est� asignado
        if (textoContador != null)
        {
            textoContador.text = mensaje;
            textoContador.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("El objeto de texto no est� asignado en el Inspector.");
        }
    }

    void DesactivarTexto()
    {
        // Desactiva el texto
        if (textoContador != null)
        {
            textoContador.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("El objeto de texto no est� asignado en el Inspector.");
        }
    }
}

