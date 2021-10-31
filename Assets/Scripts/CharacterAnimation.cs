using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator animator;


    public void SetAnimation(int number)
    {
        animator.SetInteger("Animation", number);
    }
}
