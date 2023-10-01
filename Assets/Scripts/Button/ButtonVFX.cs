using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVFX : MonoBehaviour
{
    public ParticleSystem particle;

    public void OnClick()
    {
        if(particle != null)
        {
            particle.Play();
        }
    }
}
