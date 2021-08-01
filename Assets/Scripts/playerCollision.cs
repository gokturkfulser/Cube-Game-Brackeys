using UnityEngine;

public class playerCollision : MonoBehaviour
    
{
    public movement movement;
    public gameManager manager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gameManager>().gameOver();
        }
    }
}
