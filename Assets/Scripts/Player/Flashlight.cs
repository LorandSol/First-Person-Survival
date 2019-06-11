﻿// ========================================================
// Author: Jared
// Script: Flashlight.cs
// Purpose: This script toggles the flashlight on and off.
// Date created: 21/5/19
// ========================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && flashlight.enabled == false)
        {
            flashlight.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && flashlight.enabled == true)
        {
            flashlight.enabled = false;
        }
    }
}