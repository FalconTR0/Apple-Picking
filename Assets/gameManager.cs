using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI tmpro;

    private void Start()
    {
        
    }
    private void Update()
    {
        tmpro.text = score.ToString();
    }
}
