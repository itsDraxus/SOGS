using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class WindowController : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private GameObject windowParent;
    [SerializeField] private ScreenSpace screenSpace;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    public float size;
    public float movingSize;
    public Image window;
    private int initialSiblingIndex; // Store the initial sibling index of the dragged image
    private int newSiblingIndex; // Store the new sibling index during dragging

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector3 desiredMovingSize = new Vector3(movingSize, movingSize, movingSize);
        canvasGroup.blocksRaycasts = false;
        window.rectTransform.DOScale(desiredMovingSize, 0.1f);

        // Store the initial sibling index of the dragged image
        initialSiblingIndex = rectTransform.GetSiblingIndex();

        // Move the dragged image to the top of the hierarchy
        rectTransform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / windowParent.transform.localScale;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector3 desiredSize = new Vector3(size, size, size);
        canvasGroup.blocksRaycasts = true;
        window.rectTransform.DOScale(desiredSize, 0.1f);    

        // Check if the window's position is outside the bounds of the ScreenSpace
        RectTransform screenRectTransform = screenSpace.GetComponent<RectTransform>();
        if (!RectTransformUtility.RectangleContainsScreenPoint(screenRectTransform, rectTransform.position))
        {
            rectTransform.DOAnchorPos(screenSpace.centerPos, 0.1f);
        }

        // Move the dragged image to its new sibling index
        rectTransform.SetAsLastSibling();
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
}
