using UnityEngine;
using Mediator;

public class EventMediator : MonoBehaviour
{
    [SerializeField]private Component[] components;

    public void OnTimeout()
    {
        foreach (Component i in components)
        {
            MediatorComponent component = i as MediatorComponent;
            component.Execute();
        }
    }
}
