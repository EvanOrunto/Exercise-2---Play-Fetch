using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour {
    [Header("GameObjects")]
    [SerializeField] private GameObject dogPrefab;

    [Header("Variables")]
    [SerializeField] private float spawnInterval = 1.5f;
    private float timeSinceLastSpawn = 0.0f;
    private bool fisrtSpawn = true;

    // Update is called once per frame
    void Update() {
        timeSinceLastSpawn += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (fisrtSpawn || timeSinceLastSpawn >= spawnInterval) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeSinceLastSpawn = 0.0f;
                fisrtSpawn = false; // Indicating the first spawn has occured
            }
        }


    }
}
