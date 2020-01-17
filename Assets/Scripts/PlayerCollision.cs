using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<Movement>().enabled = false;
            Debug.Log(collisionInfo.collider.name);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
