using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TankView tankView;
    void Awake()
    {

        createTank();
        SetUpCameraRef();
    }

    void createTank()
    {

        TankModel tankModel = new TankModel();
        TankController tankcontroller = new TankController();
        tankcontroller.SetRefAndCreateTank(tankModel, tankView);
    }

    void SetUpCameraRef()
    {

        
    }



}
