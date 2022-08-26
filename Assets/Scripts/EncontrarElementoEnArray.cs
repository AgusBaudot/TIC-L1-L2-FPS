using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarElementoEnArray : MonoBehaviour
{
    public GameObject[] arrayDeMesas;
    Mesa mesa;

    // Start is called before the first frame update
    void Start()
    {
        arrayDeMesas = GameObject.FindGameObjectsWithTag("Mesa");
        AsignarScriptAlArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DeactivateObjectsInArray();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DestruirMesaRandom();
        }
    }

    void DeactivateObjectsInArray()
    {
        for(int i = 0; i<arrayDeMesas.Length; i++)
        {
            arrayDeMesas[i].SetActive(false);
        }
    }
    //5. Crear una función que asigne a todos los elementos del array el script "Mesa".
    //Establecer el valor de la variable "destructible" aleatoriamente.

    void AsignarScriptAlArray()
    {
        for (int i = 0; i<arrayDeMesas.Length; i++)
        {
            {
                arrayDeMesas[i].AddComponent<Mesa>();
                mesa = arrayDeMesas[i].GetComponent<Mesa>();
                int random = Random.Range(0, 2);
                if (random == 0)
                {
                    mesa.destructible = false;
                }
                else
                {
                    mesa.destructible = true;
                }
            }
        }
    }
    //6. Crear una función que destruya el elemento del array
    //que contenga un script "Mesa" cuya variable
    //booleana "destructible" sea true (crear el script "Mesa").
    void DestruirMesaRandom()
    {
        for (int i = 0; i<arrayDeMesas.Length; i++)
        {
            if (arrayDeMesas[i].GetComponent<Mesa>().destructible)
            {
                Destroy(arrayDeMesas[i]);
            }
        }
    }
}
