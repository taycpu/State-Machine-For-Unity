using System;
using System.Collections.Generic;
using CpuStateMachine;
using UnityEngine;

public class StateMachineMono : MonoBehaviour
{
    [SerializeField] private List<ActHolder> stateHolder;
    private StateMachine stateMachine = new StateMachine();
    private List<State> states = new List<State>();
    [SerializeField] private bool initializeOnStart;
    [SerializeField] private int initializeIndex;

    private void Start()
    {
        if (initializeOnStart)
            Initialize();
    }

    public void Initialize()
    {
        states.Clear();
        for (int i = 0; i < stateHolder.Count; i++)
        {
            State state = new State();
            state.enterStateAct = stateHolder[i].stateEnterActs;
            state.updateStateAct = stateHolder[i].stateUpdateActs;
            state.exitStateAct = stateHolder[i].stateExitActs;
            states.Add(state);
        }

        if (initializeIndex > states.Count - 1)
            initializeIndex = 0;
        stateMachine.ChangeState(states[initializeIndex]);
    }

    public void ChangeState(int index)
    {
        stateMachine.ChangeState(states[index]);
    }

    public void Update()
    {
        stateMachine.Update();
    }
}