using UnityEngine;

public class PlayerColission : MonoBehaviour
{
    public Player_moviment Movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle"){
            Movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }

    }
}
