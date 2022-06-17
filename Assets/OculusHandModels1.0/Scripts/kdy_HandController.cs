using System.Xml;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
[RequireComponent(typeof(ActionBasedController))]
public class kdy_HandController : MonoBehaviour
{
    ActionBasedController controller;
    public kdy_Hand hand;
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }


    void Update()
    {
        hand.SetGrip(controller.selectAction.action.ReadValue<float>());
        hand.SetTrigger(controller.activateAction.action.ReadValue<float>());
    }
}
