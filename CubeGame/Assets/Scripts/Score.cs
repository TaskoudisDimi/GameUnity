using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    UnityEngine.UI.Text text;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + player.position.z.ToString("0");


    }
}
