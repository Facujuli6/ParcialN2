using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float effectDuration = 7f;
    public Vector3 scaleEffect = new Vector3(0.1f, 0.1f, 0.1f);

    private void Start()
    {
        gameObject.SetActive(false);
        Invoke("ActivarPowerUp", 41f);
        Invoke("ActivarPowerUp", 21f);
    }

    private void ActivarPowerUp()
    {

        transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-3f, 3f), 0f);
        gameObject.SetActive(true);
        Invoke("DesactivarPowerUp", effectDuration);
    }

    private void DesactivarPowerUp()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
          
            Debug.Log("PowerUp recogido");
    
            other.transform.localScale = scaleEffect;
            Invoke("RestaurarTamañoJugador", effectDuration);
           
        }
    }

    private void RestaurarTamañoJugador()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("Jugador");
        if (jugador != null)
        {
            jugador.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        }
    }
}
