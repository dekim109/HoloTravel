using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishnChips : MonoBehaviour
{
    public bool isFish;
    public bool isPotato;

    public GameObject Dish;
    public GameObject FishOrig;
    public GameObject PotatoOrig;
    public GameObject FishnChipsComplete;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            isFish = true;
        }

        if (other.CompareTag("Potato"))
        {
            isPotato = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            isFish = false;
        }

        if (other.CompareTag("Potato"))
        {
            isPotato = false;
        }
    }

    private void Update()
    {
        if (isFish && isPotato)
        {
            FishOrig.SetActive(false);
            PotatoOrig.SetActive(false);
            Dish.SetActive(false);
            FishnChipsComplete.SetActive(true);
        }
    }
}
