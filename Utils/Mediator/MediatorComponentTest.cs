using UnityEngine;
using Mediator;
public class MediatorComponentTest : MonoBehaviour, MediatorComponent
{
    public void Execute()
    {
        Debug.Log("pincha");
    }
}
