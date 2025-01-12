using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarSettings : MonoBehaviour
{
    [SerializeField] private Scrollbar _scrollbar;

    private void Start()
    {
        ScrollBarStartSettings();
    }

    public void ScrollBarStartSettings()
    {
        if (_scrollbar != null)
        {
            _scrollbar.value = 1;
        }
        else if (_scrollbar == null)
        {
            _scrollbar = GetComponent<Scrollbar>();
            _scrollbar.value = 1;
        }
    }
}
