using UnityEngine;

public class Movetowards : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] int speed = 100;
    Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = Player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
