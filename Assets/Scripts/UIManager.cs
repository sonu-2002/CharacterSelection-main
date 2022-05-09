using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] TankSpawner tankSpawner;
    public void BlueTankSelected()
    {

        tankSpawner.createTank(0);
        DisabledUI();
    }
    public void GreenTankSelected()
    {

        tankSpawner.createTank(1);
        DisabledUI();

    }
    public void RedTankSelected()
    {

        tankSpawner.createTank(2);
        DisabledUI();
    }
    void DisabledUI()
    {
        this.gameObject.SetActive(false);
    }
}
