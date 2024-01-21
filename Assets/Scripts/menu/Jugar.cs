using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void play()
    {
        Debug.Log("a");
        SceneManager.LoadScene("Play");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
