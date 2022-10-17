using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Transform player;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + player.Find("Score").GetComponent<Score>().score.ToString();
    }
}
