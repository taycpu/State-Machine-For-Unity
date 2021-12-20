using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;

namespace CpuStateMachine
{
    public class State
    {
        public UnityEvent enterStateAct;
        public UnityEvent updateStateAct;
        public UnityEvent exitStateAct;

        public void EnterState()
        {
            enterStateAct?.Invoke();
        }

        public void UpdateState()
        {
            updateStateAct?.Invoke();
        }

        public void ExitState()
        {
            exitStateAct?.Invoke();
        }
    }
}