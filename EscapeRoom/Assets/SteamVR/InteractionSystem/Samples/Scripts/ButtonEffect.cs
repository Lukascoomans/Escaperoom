﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffect : MonoBehaviour
    {
        public void OnButtonDown(Hand fromHand)
        {
            ColorSelf(Color.gray);
            fromHand.TriggerHapticPulse(1000);
        }

        public void OnButtonUp(Hand fromHand)
        {
            ColorSelf(Color.black);
        }

        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }
    }
}