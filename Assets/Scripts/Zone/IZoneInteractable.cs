// Title       : IZoneInteractable.cs
// Author      : Sadikur Rahman
// Description : Interface for any zone-type interaction logic.

public interface IZoneInteractable
{
    void StartCapture(TeamData team);
    void StopCapture();
}