using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    [HideInInspector] public Transform TankPos;
    [HideInInspector] public Transform TankLook;

    [SerializeField] float Smoothness;

    void Awake()
    {

        StartCoroutine(TankRef());
    }
    IEnumerator TankRef()
    {

        while (TankPos == null)
        {

            yield return new WaitForSeconds(0.1f);
        }


        transform.position = Vector3.Lerp(transform.position, TankPos.position, 1);
        transform.LookAt(TankLook);
    }

    void Update()
    {

        if (TankPos != null)
        {
            float VerticalInput = Input.GetAxis("Vertical");

            if (VerticalInput != 0)
            {
                transform.position = Vector3.Lerp(transform.position, TankPos.position, Smoothness);
                transform.LookAt(TankLook);
            }
        }
    }
}
