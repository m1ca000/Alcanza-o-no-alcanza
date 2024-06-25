using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControlerScript : MonoBehaviour
{
    public GameObject[] productos1;
    public GameObject[] productos2;
    public int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
        ActivaRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DeactivateAll()
    {
        for (int i = 0; i < productos1.Length; i++)
        {
            productos1[i].SetActive(false);
        }
        for (int i = 0; i < productos2.Length; i++)
        {
            productos2[i].SetActive(false);
        }
    }

    void ActivaRandom()
    {
        int random = Random.Range(0, productos1.Length);
        productos1[random].SetActive(true);

        int random2 = Random.Range(0, productos2.Length);
        productos2[random2].SetActive(true);
    }
}
