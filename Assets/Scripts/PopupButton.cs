using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PopupButton : MonoBehaviour
{
    public int popupChance;
    public GameObject popupPrefab;
    public float size = 1f;
    private RectTransform rectTransform;

    public GameObject parent;

    private void Awake()
    {
        rectTransform = popupPrefab.GetComponent<RectTransform>();
    }

    public void OnButtonPress()
    {
        int randomNumber = Random.Range(1, 11);
        
        if (randomNumber >= popupChance)
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(-421, 422), Random.Range(-177, 178), 0);
            GameObject instantiatedPopUp = Instantiate(popupPrefab, parent.transform);
            rectTransform = instantiatedPopUp.GetComponent<RectTransform>();
            rectTransform.localPosition = randomSpawnPos;
            Vector3 desiredSize = new Vector3(size, size, size);
            rectTransform.DOScale(desiredSize, 0.5f);
        }
        else
        {
            
        }
    }
}
