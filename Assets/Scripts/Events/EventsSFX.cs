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
    }

    private void OnDisable()
    {
        EventsGameManager.OnEnterClickPressed -= StopParticleSystem;
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
