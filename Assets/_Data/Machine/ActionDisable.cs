using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDisable : Action
{
    public float disableDelay = 0f;
    public float respawnDelay = 1f;
    private Transform ground;
    public Vector3 size;
    private MeshRenderer renderer;
    private RandomColor randomColor;
    private Transform player;
    void Start()
    {
        this.ground = GameObject.Find("Ground").transform;
        renderer = ground.GetComponent<MeshRenderer>();
        size = renderer.bounds.size;
        
    }
    public override void Act()
    {

        Invoke("Disable", this.disableDelay);
        Invoke("Respawn", this.respawnDelay);

    }

    protected virtual void Disable()
    {
        transform.parent.gameObject.SetActive(false);
    }

    protected virtual void Respawn()
    {
        Vector3 position = new Vector3(Random.Range(-size.x / 2, size.x / 2), transform.parent.gameObject.transform.position.y, Random.Range(-size.z / 2, size.z / 2));
        transform.parent.gameObject.transform.position = position;
        transform.parent.gameObject.SetActive(true);
    }

}