using UnityEngine;
using UnityEngine.SceneManagement;

public class DoofusMovement : MonoBehaviour
{
    private float speed;
    private float fallThreshold = -10f; // Adjust this threshold based on your scene setup
    private float rollSpeed = 10f; // Speed at which the cube rolls

    void Start()
    {
        GameConfig config = FindObjectOfType<GameConfig>();
        speed = config.playerData.speed; // Get speed from GameConfig
    }

    void Update()
    {
        Move();
        CheckIfFallen();
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Roll the cube based on movement
        if (movement != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rollSpeed * Time.deltaTime);
        }
    }

    private void CheckIfFallen()
    {
        if (transform.position.y < fallThreshold)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene("huhu4"); // Load the end scene
    }
}
