using UnityEngine;
using Mediator;
using System.Collections.Generic;

public class EventMediator : MonoBehaviour
{

    [SerializeField] private GameObject[] gameActors;
    private List<MediatorComponent> components;

    void Awake()
    {
        components = new List<MediatorComponent>();
    }
    void Start()
    {
        foreach(var actor in gameActors)
        {
            components.AddRange(actor.GetComponents<MediatorComponent>());
        }
    }

    public void OnTimeout()
    {
        foreach (MediatorComponent component in components)
        {
            component.Execute();
        }
    }
}
