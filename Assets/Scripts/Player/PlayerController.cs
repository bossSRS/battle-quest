// Title       : PlayerController.cs
// Author      : Sadikur Rahman
// Description : Core player class that connects components and sets team.

using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerZoneInteractor))]
public class PlayerController : BaseCharacterController
{
    private void Awake()
    {
        gameObject.name = $"Player_{team?.teamName}";
    }

    public override void SetTeam(TeamData newTeam)
    {
        base.SetTeam(newTeam);
        gameObject.name = $"Player_{newTeam.teamName}";
    }
}