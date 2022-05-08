using UnityEngine;

public class TankModel
{
    TankController tankcontroller;
    public float speed = 5f;
    public float rotDegreePerSec = 35f;

    public void SetTankController(TankController _tankcontroller)
    {
        tankcontroller = _tankcontroller;
    }

}
