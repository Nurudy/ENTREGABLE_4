using UnityEngine;
using TMPro;

public class EventsUI : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private TextMeshProUGUI distanceText;
    private string defaultText = "Distance to Enemy";

    #endregion

    private void Awake()
    {
        InitializeText();
    }


    private void OnEnable()
    {
        EventsGameManager.OnEnterClickPressed += UpdateText;
        EventsGameManager.OnEscapeClickPressed += UpdateText;
    }

    private void OnDisable()
    {
        EventsGameManager.OnEnterClickPressed -= UpdateText;
        EventsGameManager.OnEscapeClickPressed -= UpdateText;
    }

    private void InitializeText()
    {
        distanceText.text = defaultText;
    }

    private void UpdateText()
    {
        float distance = EventsPlayerController.Instance.DistanceToEnemy();
        distanceText.text = distance.ToString("F2");
        Debug.Log(distance.ToString() );
    }
}
