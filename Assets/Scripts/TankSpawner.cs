using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] GameObject Tank;
    void Awake()
    {
        Instantiate(Tank, Vector3.zero, Quaternion.identity);
    }
}
