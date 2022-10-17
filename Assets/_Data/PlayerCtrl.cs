using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public RandomColor randomcolor;
    // Start is called before the first frame update
    void Start()
    {
        this.randomcolor = transform.Find("setColor").GetComponent<RandomColor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
