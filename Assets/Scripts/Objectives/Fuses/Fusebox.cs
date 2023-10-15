using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusebox : MonoBehaviour
{
    [SerializeField] Light light1, light2, light3;
    public bool fuse1, fuse2, fuse3;
    [SerializeField] Animator doorAnimator;

    private void Start()
    {
        light1.color = Color.red;
        light2.color = Color.red;
        light3.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (fuse1)
        {
            light1.color = Color.green;
        }

        if (fuse2)
        {
            light2.color = Color.green;
        }

        if (fuse3)
        {
            light3.color = Color.green;
        }

        if (fuse1 && fuse2 && fuse3)
        {
            doorAnimator.SetTrigger("OpenDoor");
        }
    }
}
