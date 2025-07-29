// Title       : ZoneController.cs
// Author      : Sadikur Rahman
// Description : Handles team ownership, color updates, and capture state.

using UnityEngine;

public class ZoneController : MonoBehaviour, IZoneInteractable
{
    [SerializeField] private ZoneConfig config;
    [SerializeField] private Renderer zoneRenderer;

    public TeamData Owner { get; private set; }
    public bool IsContested => capturingTeam != null && capturingTeam != Owner;

    private TeamData capturingTeam;
    private float captureProgress;

    public void StartCapture(TeamData team)
    {
        capturingTeam = team;
        captureProgress = 0f;
    }

    public void StopCapture()
    {
        capturingTeam = null;
        captureProgress = 0f;
    }

    public void TickCapture()
    {
        if (capturingTeam == null || capturingTeam == Owner) return;

        captureProgress += Time.deltaTime;

        if (captureProgress >= config.captureTime)
        {
            SetOwner(capturingTeam);
            StopCapture();
        }
    }

    private void SetOwner(TeamData newOwner)
    {
        Owner = newOwner;
        zoneRenderer.material.color = newOwner.teamColor;
        Debug.Log($"Zone captured by {newOwner.teamName}");
    }

    public ZoneConfig Config => config;
}