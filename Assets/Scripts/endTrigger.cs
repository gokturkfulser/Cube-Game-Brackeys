using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public gameManager gameManager;
    void OnCollisionEnter(Collision collision)
    {
        gameManager.LevelComplete();
    }
}
