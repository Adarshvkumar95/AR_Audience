using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeController : MonoBehaviour
{
    public GameObject GazeTarget1;
    private Animator animator;
    private float lookIKWeight;
    void Start()
    {
        animator = GetComponent<Animator>();
        lookIKWeight = 1.0f;
    }
    void OnAnimatorIK(int layerIndex)
    {
        animator.SetLookAtWeight(lookIKWeight, .2f, .3f, 1.0f, 0f);
        animator.SetLookAtPosition(GazeTarget1.transform.position);
    }
}


