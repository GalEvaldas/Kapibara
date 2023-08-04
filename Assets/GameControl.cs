using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;

    private int differencesFound;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        differencesFound = 0;
        Difference.DifferenceClicked += CheckResults;
    }

    private void CheckResults()
    {
        differencesFound += 1;

        if (differencesFound == 1)
        {
            panel.SetActive(true);
Time.timeScale = 0;
        }
    }

    private void OnDestroy()
    {
        Difference.DifferenceClicked -= CheckResults;
    }
}
