// Title       : BaseCharacterController.cs
// Author      : Sadikur Rahman
// Description : Abstract base class for both players and AI characters.

using UnityEngine;

public abstract class BaseCharacterController : MonoBehaviour
{
    protected TeamData team;

    public virtual void SetTeam(TeamData newTeam)
    {
        team = newTeam;
        team.members.Add(this);
        ApplyTeamColor();
    }

    protected virtual void ApplyTeamColor()
    {
        var rend = GetComponent<Renderer>();
        if (rend != null)
            rend.material.color = team.teamColor;
    }

    public TeamData Team => team;
}