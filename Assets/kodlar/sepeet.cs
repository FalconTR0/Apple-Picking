using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sepeet : MonoBehaviour
{
    public gameManager gm;
    public float speed;
    int skor = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "domatez")
        {
            skor += 1;
            Debug.Log(skor.ToString());

            float rast = Random.Range(-0.53f, 0.52f);

            collision.gameObject.transform.position = new Vector3(rast, 1, rast);
        }
        if (collision.gameObject.tag == "domatez")
        {
            gm.score += 1;
        }

    }
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime * 1;
        
        if (Input.GetMouseButtonDown(1))
        {
            speed = -1;
        }
        if (Input.GetMouseButtonDown(2))
        {
            speed = 1;
        }
    }


   /* public void SagaGit()
    {
        speed = 1;
    }
    public void SolaGit()
    {
        speed = -1;
    }
    public void Dur()
    {
        speed = 0;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    /* void Update()
     {
         if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.Translate(0, -1 * Time.deltaTime, 0);
         }

         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.Translate(0, 1 * Time.deltaTime, 0);
         }
    */
}
