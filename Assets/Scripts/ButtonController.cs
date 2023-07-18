using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonController : MonoBehaviour
{
    public Image window;
    public float size = 1f;

    public bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        window.gameObject.SetActive(false);
    }

    public void OnButtonPress()
    {
        if (isOpen == false)
        {
            window.gameObject.SetActive(true);
            Vector3 desiredSize = new Vector3(size, size, size);
            window.rectTransform.DOScale(desiredSize, 0.5f);
            isOpen = true;
        }
        else
        {
            window.rectTransform.DOScale(Vector3.zero, 0.5f).OnComplete(() =>
            {
                window.gameObject.SetActive(false);
            });
            isOpen = false;
        }
    }
}
