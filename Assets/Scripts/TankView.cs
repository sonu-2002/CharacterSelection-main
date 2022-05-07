using UnityEngine;

public class TankView : MonoBehaviour
{

    TankController tankcontroller;

    public void SetTankController(TankController _tankcontroller)
    {
        tankcontroller = _tankcontroller;
    }
}
