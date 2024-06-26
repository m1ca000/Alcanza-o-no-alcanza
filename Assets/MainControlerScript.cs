
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Internal.Experimental.UIElements;
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
    public Text resultado;
    public GameObject notificacion;
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
        notificacion.SetActive(false);

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
        plataQueSeTiene = Random.Range(150, 1050);
        plata.text = "Plata: " + plataQueSeTiene;
    }
    public void AlcanzaYSobra()
    {
        notificacion.SetActive(true);
        if (precioTotal < plataQueSeTiene)
        {
            resultado.text = "Bien hacho!! Es correcto";
        }
        else
        {
            resultado.text = "No es correcto, mejor suerte la proxima";
        }
    }
    public void Alcanzajusto()
    {
        notificacion.SetActive(true);
        if (precioTotal == plataQueSeTiene)
        {
            resultado.text = "Bien hacho!! Es correcto";
        }
        else
        {
            resultado.text = "No es correcto, mejor suerte la proxima";
        }
    }
    public void NoAlcanza()
    {
        notificacion.SetActive(true);
        if (precioTotal > plataQueSeTiene)
        {
            resultado.text = "Bien hacho!! Es correcto";
        }
        else
        {
            resultado.text = "No es correcto, mejor suerte la proxima";
        }
    }

    void mostrarPanel()
    {
        DeactivateAll();
        notificacion.SetActive(true);
        
    }

}