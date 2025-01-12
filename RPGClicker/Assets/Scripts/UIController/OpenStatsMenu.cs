using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStatsMenu : MonoBehaviour
{
    [SerializeField] private GameObject statsMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        if (statsMenu != null)
        {
            statsMenu.SetActive(false);
        }
    }

    public void OpenAndCloseStatsMenu()
    {
        if (statsMenu.activeInHierarchy)
        {
            statsMenu.SetActive(false);
        }
        else
        {
            statsMenu.SetActive(true);
        }
    }
}
