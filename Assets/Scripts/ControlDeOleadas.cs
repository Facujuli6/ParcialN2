using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeOleadas : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public int[] cantidadesEnemigosPorOleada = { 2, 3, 5 };
    public float tiempoEntreEnemigos = 1f;
    public float tiempoEntreOleadas = 20f;
    private int oleadaActual = 0;

    void Start()
    {
        StartCoroutine(IniciarOleadas());
    }

    IEnumerator IniciarOleadas()
    {
        while (oleadaActual < cantidadesEnemigosPorOleada.Length)
        {
            for (int i = 0; i < cantidadesEnemigosPorOleada[oleadaActual]; i++)
            {
                GenerarEnemigo();
                yield return new WaitForSeconds(tiempoEntreEnemigos);
            }

            
            oleadaActual++;

            
            yield return new WaitForSeconds(tiempoEntreOleadas);
        }
    }

    void GenerarEnemigo()
    {
        Instantiate(enemigoPrefab, transform.position, Quaternion.identity);
    }
}