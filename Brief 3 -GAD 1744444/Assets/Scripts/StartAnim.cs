using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Intro Fade");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
