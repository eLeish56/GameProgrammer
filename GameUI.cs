using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : MonoBehaviour
{
    public Text TxtScore;
    public MeshRenderer bola;
    int score = 0;
    public Color Warna;
    public void Tambahscore()
    {
        score++;
        //score += 1;
        TxtScore.text = "Score : " + score;
    }
    public void Gantiwarna()
    {
        bola.material.color = Random.ColorHSV();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
