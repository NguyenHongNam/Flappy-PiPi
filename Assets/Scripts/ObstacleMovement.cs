using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float destroyXPosition = -10f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
