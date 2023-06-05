using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement playerMovement;
    bool gameHasEnded = false;
    public float delay = 2f;


    private void OnCollisionEnter(Collision collision)
    {

    

        if (collision.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            if (gameHasEnded == false)
            {
                gameHasEnded = true;
                Debug.Log("Game Over");
                Invoke("Restart", delay);
            }

        }


    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

} 
