using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public PlayerCtrl playerCtrl;
    public List<Color> Colors = new List<Color>(3);
    protected string name = "Sphere";
    protected int j = 1;
    private MeshRenderer renderer;
    private Score score1;
    public bool loser = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = transform.parent.GetComponent<MeshRenderer>();
        score1 = transform.parent.Find("Score").GetComponent<Score>();
        for (int j = 1; j < 4; j++)
        {
            
            Colors.Add(GameObject.Find(name + "_" + j).transform.GetComponent<MeshRenderer>().material.color);
           
        }
            
        int i = Random.Range(0, 3);
        renderer.material.color = Colors[i];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void setColor(GameObject g)
    {
        if (g.transform.GetComponent<MeshRenderer>().material.color == renderer.material.color)
        {
            score1.score += 1;
            switch (g.name)
            {
                case "Sphere_1":
                    while (true)
                    {
                        int i = Random.Range(0, 3);
                        if (i != 0)
                        {
                            renderer.material.color = Colors[i];
                            break;
                        }
                    }
                    break;

                case "Sphere_2":
                    while (true)
                    {
                        int i = Random.Range(0, 3);
                        if (i != 1)
                        {
                            renderer.material.color = Colors[i];
                            break;
                        }
                    }
                    break;

                case "Sphere_3":
                    while (true)
                    {
                        int i = Random.Range(0, 3);
                        if (i != 2)
                        {
                            renderer.material.color = Colors[i];
                            break;
                        }
                    }
                    break;
            } 
            
        } else
        {
            loser = true;
        }
    }
}