using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabSwitcher  MonoBehaviour
{
    [SerializeField]
    private GameObject[] tabs;
    [SerializeField]
    private Button[] buttons;
    private int activeTabIndex;
    [Tooltip(Not necessary)]
    [SerializeField]
    private Button closeButton;

    void Start()
    {
         set first tab as active
        activeTabIndex = 0;
        tabs[activeTabIndex].SetActive(true);

         set opacity for tabs
         first tab
        SwitchOpacity(buttons[0], true);
         other
        for (int i = 1; i  buttons.Length; i++)
        {
            SwitchOpacity(buttons[i], false);
        }

         add click listeners to buttons
        for (int i = 0; i  buttons.Length; i++)
        {
            int index = i;  need to capture value for listener
            buttons[i].onClick.AddListener(() = 
            SetActiveTab(index));
        }

         attach close button
        if (closeButton != null)
        {
            closeButton.onClick.AddListener(() = 
            gameObject.SetActive(false));
        }
    }

    private void SetActiveTab(int index)
    {
         disable previous active tab
        tabs[activeTabIndex].SetActive(false);
        SwitchOpacity(buttons[activeTabIndex], false);

         set new active tab
        activeTabIndex = index;
        tabs[activeTabIndex].SetActive(true);
        SwitchOpacity(buttons[activeTabIndex], true);
    }

    private void SwitchOpacity(Button tab, bool value)
    {
        CanvasGroup canvasGroup = tab.GetComponentCanvasGroup();
        canvasGroup.alpha = value  1f  0.35f;
    }
}
