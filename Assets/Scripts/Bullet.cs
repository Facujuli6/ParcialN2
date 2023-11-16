using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;

    private float minY;

    private void Start()
    {
        
        minY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
    }

    private void OnEnable()
    {
        // 
    }

    private void Update()
    {
       
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        
        if (transform.position.y < minY)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Jugador"))
        {
           
            SceneManager.LoadScene("NuevaEscena");
             Time.timeScale = 0f;
        }
    }
}


