﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Commencer ()
    {
        SceneManager.LoadScene("SE-101 SpatioPort");
    }

    public void Quitter ()
    {
        Application.Quit();
    }
}
