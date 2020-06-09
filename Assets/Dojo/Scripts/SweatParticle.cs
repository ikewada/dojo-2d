using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class SweatParticle : MonoBehaviour
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
            case CharacterController.State.Run:
                particle.Play();
                break;
            default:
                particle.Stop();
                break;
        }
    }
}
