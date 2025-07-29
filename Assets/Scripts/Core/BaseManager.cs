// Title       : BaseManager.cs
// Author      : Sadikur Rahman
// Description : Abstract base class for all manager types (GameManager, TeamManager, etc.).

using UnityEngine;

public abstract class BaseManager : MonoBehaviour
{
    public virtual void Init() { }
    public virtual void ResetManager() { }
}