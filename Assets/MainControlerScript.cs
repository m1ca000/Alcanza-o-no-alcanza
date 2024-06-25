using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControlerScript : MonoBehaviour
{
    public GameObject[] productos;
    public int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DeactivateAll()
    {
        for (int i = 0; i < productos.Length; i++)
        {
            productos[i].SetActive(false);
        }
    }
}
