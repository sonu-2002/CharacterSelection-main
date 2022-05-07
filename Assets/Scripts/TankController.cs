using UnityEngine;

public class TankController
{
    TankModel tankModel;
    TankView tankView;

    public void SetRefAndCreateTank(TankModel _tankModel, TankView _tankView)
    {

        tankModel = _tankModel;
        tankView = _tankView;
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        createTank();
    }
    void createTank()
    {

        GameObject.Instantiate(tankView, Vector3.zero, Quaternion.identity);
    }
}
