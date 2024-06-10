using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class INTERACTIONAREASCRIPT : MonoBehaviour
{
    public Text puntajeTxt;
    public int Puntos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Puntaje(int puntosItem)
    {
        Puntos += puntosItem;
    }
    void OnTriggerEnter(Collider other)
    {
        PickUpScript pickUp;
        pickUp = GetComponent<PickUpScript>();
        if (pickUp.Comida == true)
        {
            Puntaje(pickUp.puntosItem);
            Destroy(other);
        }
        else
        {
            Puntaje(pickUp.puntosItem);
        }
        Debug.Log(other);
    }
}
