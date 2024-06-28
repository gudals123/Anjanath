using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnjanathSetImpulse : MonoBehaviour
{
    private CinemachineImpulseSource impulseSource;

    private void Awake()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    public void SetImpulse()
    {
        impulseSource.GenerateImpulse();
    }
}
