using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helpers
{
    public static void ButtonDown(this GameObject btn)
    {
        RectTransform _btn = btn.GetComponent<RectTransform>();
        Vector3 scale = _btn.localScale * 0.9f;
        _btn.localScale = scale;
    }

    public static void ButtonUp(this GameObject btn)
    {
        RectTransform _btn = btn.GetComponent<RectTransform>();
        Vector3 scale = _btn.localScale * 1.11f;
        _btn.localScale = scale;
    }

}
