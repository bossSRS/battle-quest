// Title       : PlayerZoneInteractor.cs
// Author      : Sadikur Rahman
// Description : Handles zone detection and interaction using abstraction.

using UnityEngine;

[RequireComponent(typeof(BaseCharacterController))]
public class PlayerZoneInteractor : MonoBehaviour
{
    private BaseCharacterController character;

    private void Start()
    {
        character = GetComponent<BaseCharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        var zone = other.GetComponent<IZoneInteractable>();
        zone?.StartCapture(character.Team);
    }

    private void OnTriggerExit(Collider other)
    {
        var zone = other.GetComponent<IZoneInteractable>();
        zone?.StopCapture();
    }
}