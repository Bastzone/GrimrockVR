using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations: MonoBehaviour
{
    public GameObject Button;
    public GameObject DoorWood;

    public GameObject Levier;
    public GameObject Orb;
    
    public void OnButtonClick()
    {
        Button.GetComponent<Animator>().SetTrigger("ButtonPress");
        DoorWood.GetComponent<Animator>().SetTrigger("DoorWood");
    }

    public void OnLevierClick()
    {
        Levier.GetComponent<Animator>().SetTrigger("TrLevier");
        Orb.SetActive(true);
    }
}
