using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float score;
    // Update is called once per frame
    void Update()
    {
        score = 45f + player.position.z;
        scoreText.text = score.ToString("0") + " m";
    }
}
