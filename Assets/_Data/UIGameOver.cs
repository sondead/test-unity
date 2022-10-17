using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    public Transform win;
    public Transform lose; 
    private Transform player;

    void Start()
    {
        this.win = transform.Find("Win");
        this.lose = transform.Find("Lose");
        this.player = GameObject.Find("Player").transform;
    }

    void FixedUpdate()
    {
        this.ShowUIGameOver();
    }

    protected virtual void ShowUIGameOver()
    {
        if (player.Find("Score").GetComponent<Score>().score == 10)
        {
            this.win.gameObject.SetActive(true);
            return;
        }

        if (player.Find("RandomColor").GetComponent<RandomColor>().loser)
        {
            this.lose.gameObject.SetActive(true);
            return;
        }

        this.win.gameObject.SetActive(false);
        this.lose.gameObject.SetActive(false);
    }

    
}
