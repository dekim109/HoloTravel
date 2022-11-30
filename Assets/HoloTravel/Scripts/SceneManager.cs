using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject[] DescriptionPanel;
    public GameObject[] SceneObject;
    public void LoadScene1()
    {
        XRDE.DataExtractorManager.SceneIndex = "S1_211";

        DescriptionPanel[0].SetActive(true);
        DescriptionPanel[1].SetActive(false);
        DescriptionPanel[2].SetActive(false);

        SceneObject[0].SetActive(true);
        SceneObject[1].SetActive(false);
        SceneObject[2].SetActive(false);
    }

    public void LoadScene2()
    {
        XRDE.DataExtractorManager.SceneIndex = "S1_222";

        DescriptionPanel[0].SetActive(false);
        DescriptionPanel[1].SetActive(true);
        DescriptionPanel[2].SetActive(false);

        SceneObject[0].SetActive(false);
        SceneObject[1].SetActive(true);
        SceneObject[2].SetActive(false);
    }

    public void LoadScene3()
    {
        XRDE.DataExtractorManager.SceneIndex = "S1_233";

        DescriptionPanel[0].SetActive(false);
        DescriptionPanel[1].SetActive(false);
        DescriptionPanel[2].SetActive(true);

        SceneObject[0].SetActive(false);
        SceneObject[1].SetActive(false);
        SceneObject[2].SetActive(true);
    }
}
