using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStateManager : MonoBehaviour
{
    public enum State
    {
        Introduction,
        FirstStep,
        SecondStep,
        End
    }

    [HideInInspector] public State currentState;
    [HideInInspector] public State nextState;
    [HideInInspector] public TutorialManager tutorialManager;

    private void Start()
    {
        currentState = State.Introduction;
        nextState = State.FirstStep;

        tutorialManager = GetComponent<TutorialManager>();
        tutorialManager.StartIntroduction();
    }
}
