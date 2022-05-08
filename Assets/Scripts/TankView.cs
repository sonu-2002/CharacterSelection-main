using UnityEngine;

public class TankView : MonoBehaviour
{

    TankController tankcontroller;

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

        Camera.main.GetComponent<CameraMovement>().TankPos=this.gameObject.transform.GetChild(1);
        Camera.main.GetComponent<CameraMovement>().TankLook=this.gameObject.transform.GetChild(2);
    }
}
