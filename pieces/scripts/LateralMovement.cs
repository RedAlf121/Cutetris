using UnityEngine;

public class LateralMovement : MonoBehaviour
{
    // Define el tamaño del paso en unidades de mundo
    [SerializeField] private float moveStep = 32f;

    /// <summary>
    /// Mueve la pieza 1 unidad hacia la izquierda.
    /// </summary>
    public void MoveLeft()
    {
        Move(Vector2.left);
    }

    /// <summary>
    /// Mueve la pieza 1 unidad hacia la derecha.
    /// </summary>
    public void MoveRight()
    {
        Move(Vector2.right);
    }

    /// <summary>
    /// Método auxiliar para mover el objeto en la dirección indicada.
    /// </summary>
    private void Move(Vector2 direction)
    {
        transform.position += (Vector3)direction * moveStep;
    }

    /// <summary>
    /// Al producirse cualquier colisión, se elimina este script
    /// para que la pieza deje de moverse lateralmente.
    /// Se asume que la colisión proviene de otro objeto fijo (ya sea el suelo o una pieza detenida).
    /// </summary>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Se elimina este componente para desactivar el movimiento lateral.
        Destroy(this);
    }


    

}
