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

        createTank();



    }
    void createTank()
    {

        tankView = GameObject.Instantiate(tankView.gameObject, Vector3.zero, Quaternion.identity).GetComponent<TankView>();
        tankView.SetTankController(this);
    }


    public void TankMovment(float VerticalInput, float RotateInput)
    {


        tankView.GetComponent<Rigidbody>().position += tankView.transform.forward * VerticalInput * tankModel.speed * Time.deltaTime;


                          //--<< comments on transform.forward >>--\\

        /*  transform.forward gives a vector3 which is resposible for local space z Axis movement :
          For Example :
          if (Tank ratation is (0, 45, 0) on world space)
                  I want to move the tank some unit forward.
                  then on world space it's incrementation is (1,0,1):
                  And the local space incrementation is (0,0,1);
                  hance the local incrementation is very easy to write and use.

                  gameObject.transform.forward is nothing but the converter which is use to convert local space vector to world space;
                  means Local space incrementation (0,0,1) = transform.forward = world space it's incrementation (1, 0, 1);
        */

        tankView.transform.localEulerAngles += Vector3.up*tankModel.rotDegreePerSec*RotateInput*Time.deltaTime;
    }
}
