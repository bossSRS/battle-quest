// Title       : TeamManager.cs
// Author      : Sadikur Rahman
// Description : Assigns teams and registers them with the GameManager.

using System.Collections.Generic;
using UnityEngine;

public class TeamManager : BaseManager
{
    [SerializeField] private List<TeamData> teams;

    public override void Init()
    {
        foreach (var team in teams)
        {
            GameManager.Instance.RegisterTeam(team);
        }
    }

    public TeamData GetTeamById(int id)
    {
        return teams.Find(t => t.teamID == id);
    }

    public TeamData GetRandomTeam()
    {
        return teams[Random.Range(0, teams.Count)];
    }
}