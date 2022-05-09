using UnityEngine;


public class TankSpawner : MonoBehaviour
{
    [SerializeField] TankView tankView;

    void Awake()
    {



    }

    public void createTank(int TankTypeIndex)
    {

        TankController tankcontroller = new TankController();
        tankcontroller.SetRefAndCreateTank(tankView, TankTypeIndex);
    }




}
