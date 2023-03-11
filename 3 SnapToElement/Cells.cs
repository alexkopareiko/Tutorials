using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cells : MonoBehaviour
{
    // child gameobject with GridLayoutGroup component
    [SerializeField]
    private Transform grid;
    // cell prefab
    [SerializeField]
    private GameObject cellPrefab;
    // RectTransform of this gameobject
    [SerializeField]
    private RectTransform rectTransform;
    // ScrollRect of this gameobject
    [SerializeField]
    private ScrollRect scrollRect;


    private void Start()
    {
        // let's instantiate 30 gameobjects from cellPrefab
        for(int i = 0; i < 30; i++)
        {
            GameObject cell = Instantiate(cellPrefab);
            // make grid as a parent
            cell.transform.SetParent(grid);
            cell.gameObject.name = i.ToString();

            // let's snap to cell with index 29
            if (i == 29)
            {
                SnapTo(cell.GetComponent<RectTransform>());
            }
        }
    }

    private void SnapTo(RectTransform target)
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform);
        RectTransform contentPanel = scrollRect.content;
        float x = contentPanel.anchoredPosition.x;
        contentPanel.anchoredPosition =
            (Vector2)transform.InverseTransformPoint(contentPanel.position)
            - (Vector2)transform.InverseTransformPoint(target.position);
        contentPanel.anchoredPosition = new
            Vector2(x, contentPanel.anchoredPosition.y);
        scrollRect.verticalNormalizedPosition =
            Mathf.Clamp(scrollRect.verticalNormalizedPosition, 0f, 1f);
    }


}
