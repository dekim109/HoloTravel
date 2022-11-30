using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    void Start()
    {
        XRDE.DataExtractorManager.MainInteractingObject = null;
        XRDE.DataExtractorManager.SubInteractingObject = null;
    }
}
