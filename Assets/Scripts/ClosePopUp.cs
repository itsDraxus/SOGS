using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ClosePopUp : MonoBehaviour
{
    public Image popUp;

    public void OnButtonPress()
    {
            popUp.rectTransform.DOScale(Vector3.zero, 0.5f).OnComplete(() =>
            {
                Destroy(popUp.gameObject);
            });
    }
}
