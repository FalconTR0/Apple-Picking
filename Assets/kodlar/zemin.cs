using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin : MonoBehaviour
{
    public int score;
    public int HighScore;
    public bool isDead;
    public GameObject DeathScreen;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }   
}
