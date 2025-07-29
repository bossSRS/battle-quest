// Title       : PlayerHealth.cs
// Author      : Sadikur Rahman
// Description : Manages the life/death/revive logic of a player or bot.

using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxLives = 3;
    private int currentLives;

    private void Start()
    {
        currentLives = maxLives;
    }

    public void TakeDamage()
    {
        currentLives--;
        if (currentLives <= 0)
        {
            Die();
        }
    }

    public void Revive()
    {
        currentLives = Mathf.Max(1, currentLives);
    }

    private void Die()
    {
        Debug.Log($"{gameObject.name} is dead.");
        gameObject.SetActive(false);
    }

    public bool IsAlive => currentLives > 0;
}