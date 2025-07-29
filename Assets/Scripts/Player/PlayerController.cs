// Title       : PlayerController.cs
// Author      : Sadikur Rahman
// Description : Handles player-specific logic such as input and movement.

using UnityEngine;

public class PlayerController : BaseCharacterController
{
    public override void SetTeam(TeamData newTeam)
    {
        base.SetTeam(newTeam);
        Debug.Log($"Player assigned to team: {newTeam.teamName}");
    }

    private void Update()
    {
        // TODO: Add movement and shooting logic here
    }
}