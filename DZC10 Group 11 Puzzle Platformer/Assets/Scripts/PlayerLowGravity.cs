using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLowGravity : Player
{
    // Override of Player.Start() to incorporate the lower gravity
    new public void Start()
    {
        controller = GetComponent<CharacterController>();

        // Checks if the current scene contains a StateManager 
        if (stateManager == null)
        {
            Debug.Log("StateManager not found!");
        }

        // Checks if the current scene contains a LevelManager
        if (levelManager == null)
        {
            Debug.Log("LevelManager not found!");
        }

        // Lowers the gravity for this object
        gravity = 10f;
    }
}
