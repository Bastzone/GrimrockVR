using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleTrigger : MonoBehaviour
{
    public GameObject Cible;
    public GameObject SecretDoor;

    private void OnTriggerEnter(Collider other)
    {
        Cible.GetComponent<Animator>().SetTrigger("TrCible");
        SecretDoor.GetComponent<Animator>().SetTrigger("TrSecretDoor");
    }
}
