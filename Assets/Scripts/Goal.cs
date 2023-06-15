using System;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Action<PlayerControllerX> OnGoal;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemy = other.gameObject.GetComponent<EnemyX>();
            OnGoal.Invoke(enemy.LastContactedPlayer);
            Destroy(other.gameObject);
        }
    }
}