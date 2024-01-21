using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class place : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void pocicionar()
    {
        Debug.Log("a");
        SceneManager.LoadScene("Place");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
