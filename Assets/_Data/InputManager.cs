using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour


{
    public static InputManager instance; // Singleton
    public float vertical = 0;
    public float horizontal = 0;

    private void Awake()
    {
        InputManager.instance = this;
    }
    void Update()
    {
        this.GetInputMovement();
    }

    protected virtual void GetInputMovement()
    {
        this.vertical = Input.GetAxis("Vertical");
        this.horizontal = Input.GetAxis("Horizontal");

    }
}
