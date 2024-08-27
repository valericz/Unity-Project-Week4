using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int randomBlueValue;

    void Start()
    {
        // Generate a random value between 150 and 250 for Blue objects
        if (gameObject.CompareTag("Blue"))
        {
            randomBlueValue = Random.Range(150, 251); // 251 because Random.Range is exclusive at the upper limit
        }
    }

    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        // Deactivate the GameObject if it is tagged as "Red" and i equals 100
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        // Disable the Renderer if the object is tagged as "Blue" and i equals the random value
        if (gameObject.CompareTag("Blue") && i == randomBlueValue)
        {
            rend.enabled = false;
        }
    }
}
