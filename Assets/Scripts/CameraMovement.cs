using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [HideInInspector] public Transform TankPos;
    [HideInInspector] public Transform TankLook;

    [SerializeField] float Smoothness;




    void Update()
    {

        if (TankPos != null)
        {
            transform.position = Vector3.Lerp(transform.position, TankPos.position, Smoothness);
            transform.LookAt(TankLook);
        }
    }
}
