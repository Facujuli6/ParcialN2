using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
    public float tiempoLimite = 60f; // Tiempo total en segundos
    private float tiempoRestante; // Tiempo restante en segundos

    public Text textoTiempo; // Texto para mostrar el tiempo en tu interfaz de usuario

    void Start()
    {
        tiempoRestante = tiempoLimite;
    }

    void Update()
    {
        // Actualiza el tiempo restante
        tiempoRestante -= Time.deltaTime;

        // Actualiza el texto en la interfaz de usuario
        ActualizarTextoTiempo();

        // Verifica si el tiempo ha llegado a cero
        if (tiempoRestante <= 0f)
        {
            // Hacer lo que necesites al llegar a cero
            TiempoTerminado();
        }
    }

    void ActualizarTextoTiempo()
    {
        // Convierte el tiempo restante a formato minutos:segundos y actualiza el texto
        int minutos = Mathf.FloorToInt(tiempoRestante / 60f);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60f);
        textoTiempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    void TiempoTerminado()
    {
        // Aquí puedes realizar acciones adicionales al llegar a cero, como cambiar de escena
        // En este ejemplo, cargamos la escena llamada "NuevaEscena"
        SceneManager.LoadScene("GameOver");

        // Puedes agregar más acciones según tus necesidades
    }
}