using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Reference to the player object
     public GameObject player;
    //Distance between the camera and the player
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start is called before the first frame updates
    void Start()
    {
        //Calculate the initial offest between the camera's positions and the player's position
        offset = transform.position - player.transform.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Called once per frame after all Update functions have been completed
        transform.position = player.transform.position + offset;
    }
}
