using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ExitButton : MonoBehaviour
{
    public Image window;
    public GameObject parentButton;
    private ButtonController buttonController;

    private void Awake()
    {
        buttonController = parentButton.GetComponent<ButtonController>();
    }

    public void OnButtonPress()
    {
            window.rectTransform.DOScale(Vector3.zero, 0.5f).OnComplete(() =>
            {
                window.gameObject.SetActive(false);
            });

            buttonController.isOpen = false;
    }
}
