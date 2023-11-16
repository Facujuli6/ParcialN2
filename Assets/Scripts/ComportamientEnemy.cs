using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientEnemy : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
   private bool moviendoseHaciaDerecha = true;
    public float fireRate = 1f;  // Frecuencia de disparo en segundos
    private float nextFireTime;



    private void Update()
    {
        // Mueve el enemigo horizontalmente
        if (moviendoseHaciaDerecha)
        {
            transform.Translate(Vector2.right * velocidadMovimiento * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * velocidadMovimiento * Time.deltaTime);
        }

        if (Time.time > nextFireTime)
        {
            DispararBala();
            nextFireTime = Time.time + 1f / fireRate;  // Configura la pr�xima vez para disparar
        }

        // Puedes agregar l�gica adicional aqu�, como cambiar la direcci�n cuando llega a ciertos l�mites.
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {


        // Cambia la direcci�n cuando colisiona con un l�mite, por ejemplo.
        if (collision.CompareTag("Limite"))
        {
            CambiarDireccion();
        }
    }

    void CambiarDireccion()
    {
        moviendoseHaciaDerecha = !moviendoseHaciaDerecha;
    }

 
    void DispararBala()
    {
        GameObject bullet = BulletPoolManager.Instance.GetBullet();

        if (bullet != null)
        {
            bullet.transform.position = transform.position;
            bullet.SetActive(true);
        }
    
    }

}