// Title       : ZoneConfig.cs
// Author      : Sadikur Rahman
// Description : ScriptableObject to define zone capture speed and score rate.

using UnityEngine;

[CreateAssetMenu(fileName = "ZoneConfig", menuName = "BattleQuest/ZoneConfig")]
public class ZoneConfig : ScriptableObject
{
    public float captureTime = 5f;       // Seconds to capture
    public int scorePerSecond = 10;      // Points awarded per second
    public float tickRate = 1f;          // How often points are awarded
}