﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JaugeVitesse : MonoBehaviour
{
    public PlayerMove Player;
    public Slider slider;

    private void Update()
    {
        slider.value = Player.topSpeed;
    }
}
