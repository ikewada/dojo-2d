using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpEffect : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] AnimationCurve animCurve;
    public float animationTime = 4.0f;
    bool isPlaying = false;
    float process = 0;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        isPlaying = false;
        process = 0;

        material.SetFloat("_Fade", 1);
        material.SetFloat("_Effect", 0);
    }

    public void StartEffect(CharacterController.State state)
    {
        switch (state)
        {
            case CharacterController.State.Warp:
                isPlaying = true;
                StartCoroutine(PlayAnimation());
                break;
            default:
                Initialize();
                break;
        }
    }

    IEnumerator PlayAnimation()
    {
        while (isPlaying && process < 1)
        {
            process += Time.deltaTime / animationTime;
            SetProcess();
            yield return null;
        }

        Initialize();
    }

    private void SetProcess()
    {
        float p = process * animationTime;
        float value = 0;

        if (p < animationTime / 4)
        {
            value = p * 4 / animationTime;
            material.SetFloat("_Effect", value);
        }
        else if (p < animationTime / 4 * 2)
        {
            value = (p - animationTime / 4) * 4 / animationTime;
            material.SetFloat("_Fade", animCurve.Evaluate(1 - value));
        }
        else if (p < animationTime / 4 * 3)
        {
            value = (p - animationTime / 4 * 2) * 4 / animationTime;
            material.SetFloat("_Fade", animCurve.Evaluate(value));
        }
        else
        {
            value = (p - animationTime / 4 * 3) * 4 / animationTime;
            material.SetFloat("_Effect", 1 - value);
        }

    }
}
