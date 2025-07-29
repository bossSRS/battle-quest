// Title       : TeamData.cs
// Author      : Sadikur Rahman
// Description : Holds information about a team including its color, score, and members.

using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TeamData
{
    public int teamID;
    public string teamName;
    public Color teamColor;
    public int score = 0;
    public List<BaseCharacterController> members = new List<BaseCharacterController>();
}