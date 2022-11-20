using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    public int idleType;

    // Start is called before the first frame update
    void Start()
    {
        var animator = GetComponent<Animator>();
        animator.SetInteger("IdleType", idleType);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
