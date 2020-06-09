using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] CharacterController yasuharasan;
    [SerializeField] CharacterController nayukisan;
    [SerializeField] LightController lightController;

    public void OnClickAnimation(string state)
    {
        switch (state)
        {
            case "Idle":
                yasuharasan.ChangeState(CharacterController.State.Idle);
                nayukisan.ChangeState(CharacterController.State.Idle);
                break;
            case "Walk":
                yasuharasan.ChangeState(CharacterController.State.Walk);
                nayukisan.ChangeState(CharacterController.State.Walk);
                break;
            case "Run":
                yasuharasan.ChangeState(CharacterController.State.Run);
                nayukisan.ChangeState(CharacterController.State.Run);
                break;
            case "Dance":
                yasuharasan.ChangeState(CharacterController.State.Dance);
                nayukisan.ChangeState(CharacterController.State.Dance);
                break;
            case "Warp":
                yasuharasan.ChangeState(CharacterController.State.Warp);
                nayukisan.ChangeState(CharacterController.State.Warp);
                break;
        }
    }

    public void OnClickLighting(string state)
    {
        switch (state)
        {
            case "Off":
                lightController.ChangeState(LightController.State.Off);
                break;
            case "Daytime":
                lightController.ChangeState(LightController.State.Daytime);
                break;
            case "Night":
                lightController.ChangeState(LightController.State.Night);
                break;
            case "Disco":
                lightController.ChangeState(LightController.State.Disco);
                break;
        }
    }
}
