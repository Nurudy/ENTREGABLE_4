using UnityEngine;

public class EventsSFX : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private ParticleSystem particleSystem;

    #endregion

    private void Awake()
    {
        StopParticleSystem();
    }

    private void OnEnable()
    {
        EventsGameManager.OnEnterClickPressed += StartParticleSystem;
        EventsGameManager.OnEscapeClickPressed += StopParticleSystem;
    }

    private void OnDisable()
    {
        EventsGameManager.OnEnterClickPressed -= StopParticleSystem;
        EventsGameManager.OnEscapeClickPressed -= StartParticleSystem;
    }
    private void StartParticleSystem()
    {
        particleSystem.Play();
    }
    
    private void StopParticleSystem()
    {
        particleSystem.Stop();
    }
}
