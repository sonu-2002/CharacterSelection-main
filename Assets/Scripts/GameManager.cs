using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] TankView tankView;
    void Awake()
    {

        createTank();
       
    }

    void createTank()
    {

        
        TankController tankcontroller = new TankController();
        tankcontroller.SetRefAndCreateTank(tankView);
    }

   


}
