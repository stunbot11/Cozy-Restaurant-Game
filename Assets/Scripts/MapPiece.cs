using UnityEngine;

public class MapPiece : MonoBehaviour
{
    public GameObject buttonPress;
    public float heightMax, heightMin, startPos, speed;
    public int direction = 1;

    private void Start()
    {
        startPos = buttonPress.transform.localPosition.y;
    }

    private void Update()
    {
        buttonPress.transform.position += new Vector3(0, direction * speed * Time.deltaTime, 0);
        if (buttonPress.transform.localPosition.y < (startPos + heightMin))
            direction = 1;
        else if (buttonPress.transform.localPosition.y > (startPos + heightMax))
            direction = -1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            buttonPress.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            buttonPress.SetActive(false);
    }
}
