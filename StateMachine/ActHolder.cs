using System;
using UnityEngine.Events;

[Serializable]
public class ActHolder
{
    public string stateName;
    public UnityEvent stateEnterActs;
    public UnityEvent stateUpdateActs;
    public UnityEvent stateExitActs;
}