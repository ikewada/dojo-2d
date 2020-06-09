using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightRotator : MonoBehaviour
{
    [SerializeField] AnimationCurve animCurve;
    [SerializeField] float speed = 10;
    private float random;

    void Start()
    {
        random = Random.Range(0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        var t = Time.time / speed + random;
        var r = animCurve.Evaluate(t - Mathf.Floor(t));
        var v = new Vector3(0, 0, r);
        transform.localEulerAngles = v;
    }
}
