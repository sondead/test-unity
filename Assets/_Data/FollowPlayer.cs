using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(6, 4, 0);
    
    void Start()
    {
        this.player = GameObject.Find("Player").transform;
    }

    
    void Update()
    {
        transform.position = this.player.transform.position + this.offset;
    }

    private void FixedUpdate()
    {
        transform.LookAt(this.player.position); 
    }
}
