using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

    
public class SwitchHexNut : XRBaseInteractable
{
    private GameObject nut;

    void Awake()
    {
        XRSocketInteractor socket = gameObject.GetComponent<XRSocketInteractor>();
        //socket.onSelectEntered.AddListener(HatCheck);

        nut = GameObject.FindGameObjectWithTag("HexNut");
        Debug.Log("socket from Awake: " + socket);
    }

    public void HexNut(XRBaseInteractable obj)
    {
        if (obj.gameObject.CompareTag("HexNut"))
        {   
            Debug.Log("Destroy hex nut!");
            Destroy(nut);

        }
    }
}
