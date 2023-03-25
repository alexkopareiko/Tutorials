using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    private float startTimeScale;
    private float startFixedDeltaTime;
    private float slowMotionTimeScale = 0.1f;

    private void Start()
    {
        // set scale for slow mo
        startTimeScale = Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime;
    }

    private void Update()
    {
        // check if pressed LMB
        if (Input.GetMouseButton(0))
        {
            SlowMode(true);
        }
        else
        {
            SlowMode(false);
        }
    }

    public void SlowMode(bool _value)
    {
        // slow time
        if (_value)
        {
            Time.timeScale = slowMotionTimeScale;
            Time.fixedDeltaTime = startFixedDeltaTime 
                * slowMotionTimeScale;
        }
        // return back
        else
        {
            Time.timeScale = startTimeScale;
            Time.fixedDeltaTime = startFixedDeltaTime;
        }
    }
}



