using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFuseBox : MonoBehaviour
{
    private GameObject gameObj;
    [SerializeField] GameObject fuseOb1, fuseOb2, fuseOb3;
    public GameObject handUI;

    [SerializeField] bool fuse1, fuse2, fuse3, doorOpen, fusesFull;

    [SerializeField] Inventory inventory;

    [SerializeField] Light lightBulb;

    [SerializeField] Animator animator, doorAnimator;

    private bool inReach;


    void Start()
    {
        gameObj = this.gameObject;

        handUI.SetActive(false);

        lightBulb.color = Color.red;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach" && !fusesFull)
        {
            inReach = true;
            handUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            handUI.SetActive(false);
        }
    }

    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            if (doorOpen)
            {
                if (inventory.fuse1 == true)
                {
                    fuseOb1.SetActive(true);
                    fuse1 = true;
                    handUI.SetActive(false);
                }
    
                if (inventory.fuse2 == true)
                {
                    fuseOb2.SetActive(true);
                    fuse2 = true;
                    handUI.SetActive(false);
                }

                if (inventory.fuse3 == true)
                {
                    fuseOb3.SetActive(true);
                    fuse3 = true;
                    handUI.SetActive(false);
                }
            }

            if (doorOpen == false)
            {
                animator.SetTrigger("OpenFuse");
                doorOpen = true;
            }
        }

        if (fuse1 == true && fuse2 == true && fuse3 == true)
        {
            lightBulb.color = Color.green;
            fusesFull = true;
            doorAnimator.SetTrigger("OpenDoor");
        }
    }
}