using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightController : MonoBehaviour
{
    [SerializeField] Light2D globalLight;
    [SerializeField] GameObject dayLight;
    [SerializeField] GameObject nightLight;
    [SerializeField] GameObject discoLight;

    public enum State
    {
        Off, Daytime, Night, Disco
    }

    void Start()
    {
        ChangeState(State.Off);
    }

    public void ChangeState(State state)
    {
        switch (state)
        {
            case State.Off:
                AllLightUnactive();
                SetGlobalLight(1.0f, Color.white);
                break;
            case State.Daytime:
                AllLightUnactive();
                SetGlobalLight(0.8f, Color.white);
                dayLight.SetActive(true);
                break;
            case State.Night:
                AllLightUnactive();
                SetGlobalLight(0.3f, new Color(0, 0.6f, 1.0f, 1.0f));
                nightLight.SetActive(true);
                break;
            case State.Disco:
                AllLightUnactive();
                SetGlobalLight(0.2f, new Color(0, 0.6f, 1.0f, 1.0f));
                discoLight.SetActive(true);
                break;
        }
    }

    private void SetGlobalLight(float val, Color col)
    {
        globalLight.intensity = val;
        globalLight.color = col;
    }

    public void AllLightUnactive()
    {
        dayLight.SetActive(false);
        nightLight.SetActive(false);
        discoLight.SetActive(false);
    }
}
