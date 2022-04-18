using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiedestalTrigger : MonoBehaviour
{
    public GameObject Orb;
    public GameObject Piedestal;
    public GameObject Canvas;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Orb")
        {
            Orb.transform.position = Piedestal.GetComponent<BoxCollider>().transform.position;
            Canvas.SetActive(true);
        }
    }
}
