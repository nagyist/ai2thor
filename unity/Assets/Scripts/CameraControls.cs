// Copyright Allen Institute for Artificial Intelligence 2017
using System.Collections;
using UnityEngine;

public class CameraControls : MonoBehaviour {
    Camera cam;

    void Start() {
        cam = GetComponent<Camera>();
        cam.enabled = false;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
            cam.enabled = !cam.enabled;
        }
    }
}
