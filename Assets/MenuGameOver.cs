using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public string nombreEscenaPrincipal = "SampleScene";

    private void Start()
    {
        // Aseg�rate de asignar el m�todo OnClick al evento del bot�n
        // Puedes hacer esto directamente en el editor de Unity
    }

    // M�todo llamado cuando el bot�n es presionado
    public void OnClickReiniciar()
    {
        // Reinicia la escena principal
        SceneManager.LoadScene(nombreEscenaPrincipal);
    }
}
