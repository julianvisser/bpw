using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{

    public GameObject player;
    public Canvas prompt;

    public Vector3 tpOffset;

    private bool playerIsInside = false;

    // Start is called before the first frame update
    void Start()
    {
        prompt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsInside)
        {
            // Debug.Log("inside");
            //if (Input.GetKeyDown("E"))
            //{
            //    Debug.Log("E pressed");
            //}
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("e pressed");
                player.SetActive(false);
                player.transform.position = player.transform.position + tpOffset;
                player.SetActive(true);
                playerIsInside = false;
            }
        }
    }

    void OnTriggerEnter(Collider player)
    {
        playerIsInside = true;

        prompt.enabled = true;
    }

    void OnTriggerExit(Collider player)
    {
        playerIsInside = false;

        prompt.enabled = false;
    }
}
