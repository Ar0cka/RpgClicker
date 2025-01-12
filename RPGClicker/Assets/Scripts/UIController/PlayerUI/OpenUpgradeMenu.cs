using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenUpgradeMenu : MonoBehaviour
{
    [SerializeField] private GameObject _upgradePanel;
    [SerializeField] private ScrollbarSettings _scrollbar;

    public void Open()
    {
        if (!_upgradePanel.activeInHierarchy)
        {
            _upgradePanel.SetActive(true);
            _scrollbar.ScrollBarStartSettings();
        }
        else if (_upgradePanel.activeInHierarchy)
        {
            _upgradePanel.SetActive(false);
        }

    }
}