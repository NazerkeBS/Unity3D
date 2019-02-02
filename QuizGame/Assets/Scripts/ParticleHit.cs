using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHit : MonoBehaviour
{
    private ParticleSystem particle;

    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
    }

    void Start()
    {
        PlayParticle();
    }
    void PlayParticle() {
        particle.Play();
    }
}
