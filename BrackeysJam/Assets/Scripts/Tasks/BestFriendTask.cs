using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestFriendTask : MonoBehaviour
{
    public float triggerRadius = 2f;

    public GameObject bffCheckmark;

    void Update()
    {
        if (Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) <= triggerRadius)
        {
            bffCheckmark.SetActive(true);
            // Make a task complete sound
        }
    }
}
