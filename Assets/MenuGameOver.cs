using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{ 
    public void ReiniciarNuestroJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
   
