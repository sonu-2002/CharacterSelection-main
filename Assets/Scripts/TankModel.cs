using UnityEngine;

public class TankModel
{
    TankController tankcontroller;
    public float speed;
    public float rotDegreePerSec;
    public Material TankMat;

    public void SetTankController(TankController _tankcontroller)
    {
        tankcontroller = _tankcontroller;
    }

    public TankModel(float _speed, float _rotAngle, Material _TankMat)
    {

        speed = _speed;
        rotDegreePerSec = _rotAngle;
        TankMat = _TankMat;
    }


}
