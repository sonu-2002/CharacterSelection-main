using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] TankView tankView;
    void Awake()
    {

        createTank();
    }

    void createTank()
    {

        TankModel tankModel = new TankModel();
        TankController tankcontroller = new TankController();
        tankcontroller.SetRefAndCreateTank(tankModel, tankView);
    }

}
