using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    // Declares classes and variables to be used
    public TextMeshProUGUI countText;
    public GameObject winText;
    public Vector3 v3Force;
    public KeyCode keyPositive;
    public KeyCode keyNegative;
    private int score;


    // Will run automatically in each frame of the game
    void Update()
    {
        // Depending on user input, apply the v3Force defined in Unity
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }

    // Will run before the game commences
    void Start()
    {
        // Set score to zero
        score = 0;
        // Call method
        SetScore();

        // Hide winText
        winText.SetActive(false);

    }

    // Display score and win text if player collects all pickups
    void SetScore()
    {
        // Update visible score for user
        countText.text = "Score: " + score.ToString();

        if (score >= 17)
        {
            winText.SetActive(true);
        }
    }

    // Allow for pickups to be collected
    private void OnTriggerEnter(Collider other)
    {
        // If pickup has tag cube, hide object and increment score by 1
        if (other.gameObject.CompareTag("cube"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;

            // Call SetScore to update the score for user on the screen
            SetScore();
        }

        // If pickup has tag capsule, hide object and increment score by 2
        else if (other.gameObject.CompareTag("capsule"))
        {
            other.gameObject.SetActive(false);
            score = score + 2;

            // Call SetScore to update the score for user on the screen
            SetScore();
        }

        // If pickup has tag cylinder, hide object and increment score by 3
        else if (other.gameObject.CompareTag("cylinder"))
        {
            other.gameObject.SetActive(false);
            score = score + 3;

            // Call SetScore to update the score for user on the screen
            SetScore();
        }
    }
}
