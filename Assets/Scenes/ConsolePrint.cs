using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    // Declare an integer i that starts at 3
    private int i = 3;

    // Update is called once per frame
    void Update()
    {
        // Increment i by 1
        i++;

        // Print the GameObject's name and the value of i
        Debug.Log(gameObject.name + ":" + i);
    }
}
