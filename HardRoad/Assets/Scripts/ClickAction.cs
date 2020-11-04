using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAction : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject welcomeHandler;
    [SerializeField]
    private GameObject startHandler;

    public void OnPointerClick(PointerEventData eventData)
    {
        welcomeHandler.SetActive(false);
        this.gameObject.SetActive(false);

        PauseFeature.Unpause();

        startHandler.SetActive(true);
    }
}
