using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorIDScript : MonoBehaviour
{
    public int speedID;

    void Awake()
    {
        speedID = Animator.StringToHash("Speed");
    }
}
