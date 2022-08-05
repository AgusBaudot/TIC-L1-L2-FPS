using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Netbook : MonoBehaviour
{
    public GameObject net;
    public Transform SpawnPoint;
    public Text AvisoSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Player" && Input.GetKey(KeyCode.N))
        {
            Instantiate(net, SpawnPoint.position, gameObject.transform.rotation);
        }
        if(col.gameObject.tag == "Player")
        {
            AvisoSpawn.text = "Estas cerca de un carrito, podés spawnear una netbook presionando la tecla N";
        }
    }
}
