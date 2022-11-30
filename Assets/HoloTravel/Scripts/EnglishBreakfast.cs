using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnglishBreakfast : MonoBehaviour
{
    public GameObject Pan;
    public GameObject Food;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pan"))
        {
            Pan.SetActive(false);
            Food.SetActive(true);
        }        
    }
}
