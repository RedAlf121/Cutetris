using UnityEngine;

public class FallingPiece : MonoBehaviour
{
    // Definimos el paso en unidades de mundo
    [SerializeField] private float step = 32f;

    /// <summary>
    /// Mueve la pieza 1 unidad hacia abajo.
    /// </summary>
    public void MoveDown()
    {
        transform.position += Vector3.down * step;
    }

    /// <summary>
    /// Al producirse cualquier colisión, se elimina este script
    /// para que la pieza deje de caer.
    /// Se asume que la colisión proviene de otro objeto fijo (ya sea el suelo o una pieza detenida).
    /// </summary>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hay una colisión");
        Destroy(this);
    }

}
