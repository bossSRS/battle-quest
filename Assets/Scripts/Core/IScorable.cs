// Title       : IScorable.cs
// Author      : Sadikur Rahman
// Description : Interface for any system that provides scoring logic.

public interface IScorable
{
    void AddPoints(TeamData team, int amount);
    int GetScore(TeamData team);
}