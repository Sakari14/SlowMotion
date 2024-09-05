using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo : MonoBehaviour
{
    //https://www.youtube.com/watch?v=nLdbZrqaf24
    //Video used for code
    public float SlowDownTo = 0.05f;
    public float SlowDownTime = 8f;

    void Update()
    {
        Time.timeScale += (1f / SlowDownTime) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        if (Input.GetKeyDown(KeyCode.R))
        {
            MakeSlowMotionEffect();
        }
    }

    public void MakeSlowMotionEffect()
    {
        Time.timeScale = SlowDownTo;
    }
}