using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void menu()
    {
        Debug.Log("a");
        SceneManager.LoadScene("Inicio");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
