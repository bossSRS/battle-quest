// Title       : ZoneCaptureLogic.cs
// Author      : Sadikur Rahman
// Description : Handles scoring for zones owned by teams over time.

using UnityEngine;

public class ZoneCaptureLogic : MonoBehaviour
{
    [SerializeField] private ZoneController zoneController;
    [SerializeField] private ScoreSystem scoreSystem;

    private float tickTimer = 0f;

    private void Update()
    {
        zoneController.TickCapture();

        // Only award score if the zone is owned
        if (zoneController.Owner == null) return;

        tickTimer += Time.deltaTime;

        if (tickTimer >= zoneController.Config.tickRate)
        {
            scoreSystem.AddPoints(zoneController.Owner, zoneController.Config.scorePerSecond);
            tickTimer = 0f;
        }
    }
}