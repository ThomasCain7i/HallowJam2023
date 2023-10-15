using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFuse : MonoBehaviour
{
    private GameObject gameObj;
    public GameObject handUI;

    [SerializeField] bool fuse1, fuse2, fuse3, fuse4;

    [SerializeField] Inventory inventory;

    private bool inReach;


    void Start()
    {
        gameObj = this.gameObject;

        handUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
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
            handUI.SetActive(false);

            if(fuse1)
            {
                inventory.fuse1 = true;
            }

            if (fuse2)
            {
                inventory.fuse2 = true;
            }

            if (fuse3)
            {
                inventory.fuse3 = true;
            }

            if (fuse3)
            {
                inventory.fuse4 = true;
            }

            Destroy(gameObject);
        }
    }
}