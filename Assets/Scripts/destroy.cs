using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    // Start is called before the first frame update
    public void destruir()
    {
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("localizar");
        foreach (GameObject objeto in objetos)
            GameObject.Destroy(objeto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
