using OWML.Common;
using OWML.ModHelper;
using OWML.Utils;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RemovalHelmetMod
{
    public class RemovalHelmetMod : ModBehaviour
    {
        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {
            ModHelper.Console.WriteLine($"Removal Helmet Mod loaded!!");

        }

        private void Update()
        {
           if (Keyboard.current.hKey.wasPressedThisFrame)
            {
                Locator.GetPlayerSuit().RemoveHelmet();
            }
           if (Keyboard.current.jKey.wasPressedThisFrame)
            {
                Locator.GetPlayerSuit().PutOnHelmet();
            }
        }
    }
}
