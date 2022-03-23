
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header ("Petrol Points")]
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;

    [Header("Enemy")]
    [SerializeField] private Transform enemy;

    [Header("Movement parameters")]
    [SerializeField] private float speed;

    private void Update()
    {
        MoveInDirection(1);
    }

    private void MoveInDirection(int _direction)
    {
        //Make enemy face direction

        //Move in that direction
        enemy.position = new Vector3(enemy.position.x + Time.deltaTime * _direction * speed,
            enemy.position.y, enemy.position.z);
    }
}
