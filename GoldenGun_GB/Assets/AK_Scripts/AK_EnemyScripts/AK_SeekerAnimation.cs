using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_SeekerAnimation : MonoBehaviour
{
    public Animator animator;

    string currentState;

    public string SEEKER_IDLE;
    public string SEEKER_ATTACK;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }
}
