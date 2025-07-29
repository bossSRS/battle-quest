// Title       : ScoreSystem.cs
// Author      : Sadikur Rahman
// Description : Implements the scoring logic using a dictionary and updates team data.

using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour, IScorable
{
    private Dictionary<TeamData, int> teamScores = new Dictionary<TeamData, int>();

    public void AddPoints(TeamData team, int amount)
    {
        if (!teamScores.ContainsKey(team))
            teamScores[team] = 0;

        teamScores[team] += amount;
        team.score = teamScores[team];

        Debug.Log($"➕ {amount} points added to {team.teamName}. Total: {team.score}");
    }

    public int GetScore(TeamData team)
    {
        return teamScores.TryGetValue(team, out int score) ? score : 0;
    }
}