using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class SmokeParticle : MonoBehaviour
{
    ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        particle.Stop();
    }

    public void StartEffect(CharacterController.State state)
    {
        ParticleSystem.EmissionModule emission = particle.emission;

        switch (state)
        {
            case CharacterController.State.Walk:
                emission.rateOverTime = 3;
                particle.Play();
                break;

            case CharacterController.State.Run:
                emission.rateOverTime = 10;
                particle.Play();
                break;
            default:
                particle.Stop();
                break;
        }
    }
}
