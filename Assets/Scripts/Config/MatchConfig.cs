// Title       : MatchConfig.cs
// Author      : Sadikur Rahman
// Description : ScriptableObject holding configurable match settings.

using UnityEngine;

[CreateAssetMenu(fileName = "MatchConfig", menuName = "BattleQuest/MatchConfig")]
public class MatchConfig : ScriptableObject
{
    public int totalTeams = 5;
    public int playersPerTeam = 4;
    public int targetScore = 1000;
    public int maxLivesPerPlayer = 3;
}