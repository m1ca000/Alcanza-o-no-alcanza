﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControlerScript : MonoBehaviour
{
    public GameObject[] productos1;
    public GameObject[] productos2;
    public int currentIndex = -1;
    public Text precio1;
    public Text precio2;
    int precioTotal;
    int plataQueSeTiene;
    public Text plata;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
        ActivaRandom();
        Plata();
        
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
        ProductoScript producto1;
        producto1 = productos1[random].GetComponent<ProductoScript>();
        precio1.text = producto1.precio.ToString();
        
        int random2 = Random.Range(0, productos2.Length);
        productos2[random2].SetActive(true);
        ProductoScript producto2;
        producto2 = productos2[random2].GetComponent<ProductoScript>();
        precio2.text = producto2.precio.ToString();



        producto1 = productos1[random].GetComponent<ProductoScript>();
        producto2 = productos2[random2].GetComponent<ProductoScript>();
        precioTotal = producto1.precio + producto2.precio;
    }

    void Plata()
    {
        plataQueSeTiene = Random.Range(150, 100000);
        plata.text = "Plata: " + plataQueSeTiene;
    }
    public void AlcanzaYSobra()
    {
        if (precioTotal < plataQueSeTiene)
        {
            Debug.Log("Bien hacho!! Es correcto");
        }
        else
        {
            Debug.Log("No es correcto, mejor suerte la proxima");
        }
    }
    public void Alcanzajusto()
    {
        if (precioTotal == plataQueSeTiene)
        {
            Debug.Log("Bien hacho!! Es correcto");
        }
        else
        {
            Debug.Log("No es correcto, mejor suerte la proxima");
        }
    }
    public void NoAlcanza()
    {
        if (precioTotal > plataQueSeTiene)
        {
            Debug.Log("Bien hacho!! Es correcto");
        }
        else
        {
            Debug.Log("No es correcto, mejor suerte la proxima");
        }
    }
}