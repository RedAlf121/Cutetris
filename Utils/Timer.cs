using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace TimerScript
{
    public class Timer : MonoBehaviour
    {
        [Header("Timeout signal")]
        [Tooltip("Evento cuando se acaba el tiempo del timer")]
        [SerializeField] private UnityEvent timeout;

        [Header("Propiedades del Timer")]
        [Tooltip("Tiempo de espera del timer hasta 5 segundos como maximo")]
        [Range(0, 5f)]
        [SerializeField] private float waitTime = 1f;

        [Tooltip("El timer se va a ejecutar en cuanto se cargue")]
        [SerializeField] private bool autoPlay = true;

        [Tooltip("Si se desea utilizar en bucle")]
        [SerializeField] private bool loop = false;

        private Coroutine countdown;

        void Start()
        {
            if (autoPlay) Run();
        }

        public void Run()
        {
            countdown = StartCoroutine(Wait());
        }

        public void Stop()
        {
            StopCoroutine(countdown);
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(waitTime);
            timeout.Invoke();
            if (loop) Run();
        }
    }
}
