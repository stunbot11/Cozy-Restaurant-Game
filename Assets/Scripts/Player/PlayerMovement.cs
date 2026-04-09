using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController controller;

    private void Start()
    {
        controller = GetComponent<PlayerController>();
    }
}
