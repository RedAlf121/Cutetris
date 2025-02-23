using UnityEngine;
using System.Collections;

public class TestTimer : MonoBehaviour
{
    // Intervalo de tiempo en segundos (1 segundo)
    [SerializeField] private float interval = 1f;

    void Start()
    {
        // Inicia la corrutina que invocará MoveDown() periódicamente.
        StartCoroutine(MoveDownCoroutine());
    }

    /// <summary>
    /// Corutina que espera cada 1 segundo y luego busca y mueve las piezas activas.
    /// </summary>
    private IEnumerator MoveDownCoroutine()
    {
        while (true)
        {
            // Espera el intervalo definido.
            yield return new WaitForSeconds(interval);
            Debug.Log("pasó un segundo");

            // Busca todas las piezas en la escena que tengan la etiqueta "Piece"
            GameObject[] pieces = GameObject.FindGameObjectsWithTag("Piece");
            foreach (GameObject piece in pieces)
            {
                // Verifica si la pieza tiene el componente FallingPiece
                FallingPiece fallingPiece = piece.GetComponent<FallingPiece>();
                if (fallingPiece != null)
                {
                    Debug.Log("se movió la pieza");
                    fallingPiece.MoveDown();
                }
            }
        }
    }
}
