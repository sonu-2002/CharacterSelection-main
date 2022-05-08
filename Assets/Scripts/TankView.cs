using UnityEngine;
using System.Collections.Generic;

public class TankView : MonoBehaviour
{


    public List<TankProperties> Tank;
    TankController tankcontroller;
    public MeshRenderer[] Childs;

    float VerticalInput;
    float RotateInput;

    public void SetTankController(TankController _tankcontroller)
    {
        tankcontroller = _tankcontroller;
    }

    void FixedUpdate()
    {

        if (tankcontroller != null)
        {
            VerticalInput = Input.GetAxis("Vertical");
            RotateInput = Input.GetAxis("Horizontal");

            tankcontroller.TankMovment(VerticalInput, RotateInput);
        }
    }

    void Awake()
    {
        SetUpCameraRef();
    }

    void SetUpCameraRef()
    {

        Camera.main.GetComponent<CameraMovement>().TankPos = this.gameObject.transform.GetChild(1);
        Camera.main.GetComponent<CameraMovement>().TankLook = this.gameObject.transform.GetChild(2);
    }
}


[System.Serializable]
public class TankProperties
{



    public int speed;
    public int RotAngle;
    public TankTypes tankType;
    public Material TankMat;
}
