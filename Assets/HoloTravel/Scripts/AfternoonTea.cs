using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfternoonTea : MonoBehaviour
{
    public GameObject[] Tier;
    public string TierTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TierTag))
        {
            Tier[0].SetActive(false);
            Tier[1].SetActive(true);
        }
    }
}
