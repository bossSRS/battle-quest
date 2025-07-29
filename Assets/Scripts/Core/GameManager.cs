// Title       : GameManager.cs
// Author      : Sadikur Rahman
// Description : Manages the game lifecycle, state transitions, and win conditions.

using System.Collections.Generic;
using UnityEngine;

public class GameManager : BaseManager
{
    public static GameManager Instance { get; private set; }

    [Header("Match Settings")]
    [SerializeField] private MatchConfig matchConfig;
    [SerializeField] private ScoreSystem scoreSystem;

    private MatchState matchState = MatchState.WaitingToStart;
    private List<TeamData> teams = new List<TeamData>();

    public MatchState MatchState => matchState;
    public int TargetScore => matchConfig.targetScore;
    public List<TeamData> Teams => teams;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public override void Init()
    {
        matchState = MatchState.InProgress;
        Debug.Log("🕹️ Match Started");
    }

    public void EndGame(TeamData winner)
    {
        matchState = MatchState.Finished;
        Debug.Log($"🏆 Team {winner.teamName} Wins!");
    }

    public void CheckWinCondition()
    {
        foreach (var team in teams)
        {
            if (team.score >= matchConfig.targetScore)
            {
                EndGame(team);
                break;
            }
        }
    }

    public void RegisterTeam(TeamData team)
    {
        if (!teams.Contains(team)) teams.Add(team);
    }
}
