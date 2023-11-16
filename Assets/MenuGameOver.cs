using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public string nombreEscenaPrincipal = "SampleScene";

    private void Start()
    {
        // Asegúrate de asignar el método OnClick al evento del botón
        // Puedes hacer esto directamente en el editor de Unity
    }

    // Método llamado cuando el botón es presionado
    public void OnClickReiniciar()
    {
        // Reinicia la escena principal
        SceneManager.LoadScene(nombreEscenaPrincipal);
    }
}
