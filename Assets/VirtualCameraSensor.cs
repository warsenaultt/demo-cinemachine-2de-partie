using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VirtualCameraSensor : MonoBehaviour
{
    [SerializeReference] CinemachineVirtualCamera vcam;

    void Start()
    {
        vcam.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vcam.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vcam.gameObject.SetActive(false);

        }
    }
}
