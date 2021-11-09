using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class GuardController : MonoBehaviour
{
    public int animState = 0;
    int lastAnimState = 0;
    Animator anm = null;

    // Start is called before the first frame update
    void Start()
    {
        anm = GetComponent<Animator>();

        UpdateAnim();
    }

    void UpdateAnim()
    {
        if (animState != lastAnimState)
        {
            anm.SetInteger("State", animState);
            lastAnimState = animState;
        }
    }
}
