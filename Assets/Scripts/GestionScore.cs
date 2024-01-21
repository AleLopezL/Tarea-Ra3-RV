using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionScore : MonoBehaviour
{
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
        

    }
    public void cambiarScore()
    {

        GameObject.Find("Puntuacion").GetComponent<TMP_Text>().text = Score.ToString();

    }
}
