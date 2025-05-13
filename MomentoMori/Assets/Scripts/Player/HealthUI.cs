using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    PlayerController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("playerRemy").GetComponent<PlayerController>();
    }

    public void Health()
    {
        TextMeshProUGUI gameOver = GameObject.Find("GameOver").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI overText = GameObject.Find("overText").GetComponent<TextMeshProUGUI>();
        Image overButton = GameObject.Find("overButton").GetComponent<Image>();

        if (player.playerHealth <= 0)
        {
            Destroy(gameObject);

            gameOver.enabled = true;
            overButton.enabled = true;
            overText.enabled = true;
        }
    }


}
