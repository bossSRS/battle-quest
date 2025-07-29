// Title       : PlayerSpawner.cs
// Author      : Sadikur Rahman
// Description : Spawns player prefab and assigns to a random team on game start.

using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private TeamManager teamManager;

    private void Start()
    {
        SpawnPlayers();
    }

    private void SpawnPlayers()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Transform spawnPoint = spawnPoints[i];

            GameObject playerGO = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
            PlayerController playerController = playerGO.GetComponent<PlayerController>();

            if (playerController != null)
            {
                TeamData team = teamManager.GetRandomTeam();
                playerController.SetTeam(team);
                Debug.Log($"✅ Spawned player and assigned to team: {team.teamName}");
            }
        }
    }
}