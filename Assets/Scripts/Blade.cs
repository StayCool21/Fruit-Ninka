using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Camera mainCamera;
    private Collider bladeCollider;
    private TrailRenderer bladeTrail;
    private bool slicing;

    // read from external scripts, but only set from this class
    public Vector3 direction { get; private set; }
    public float sliceForce = 5f;
    public float minSliceVelocity = 0.01f;

    private void Awake() {
        mainCamera = Camera.main;
        bladeCollider = GetComponent<Collider>();
        bladeTrail = GetComponentInChildren<TrailRenderer>();
    }

    private void OnEnable() {
        StopSlicing();
    }

    private void OnDisable() {
        StopSlicing();
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            StartSlicing();
        }
        else if (Input.GetMouseButtonUp(0)) {
            StopSlicing();
        }
        else if (slicing) {
            ContinueSlicing();
        }

    }

    private void StartSlicing() {
        Vector3 newPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0f;

        transform.position = newPosition;

        slicing = true;
        bladeCollider.enabled = true;

        bladeTrail.enabled = true;
        bladeTrail.Clear();
    }

    private void StopSlicing() {
        slicing = false;
        bladeCollider.enabled = false;

        bladeTrail.enabled = false;
    }

    private void ContinueSlicing() {
        // conversion from screen space to world space...
        Vector3 newPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        // even though this is a 3D game, we're somewhat ignoring the z axis
        newPosition.z = 0f;

        direction = newPosition - transform.position;

        float velocity = direction.magnitude / Time.deltaTime;

        // blade collider is enabled only if velocity is greater than minSliceVelocity
        bladeCollider.enabled = velocity > minSliceVelocity;

        transform.position = newPosition;
    }
}

