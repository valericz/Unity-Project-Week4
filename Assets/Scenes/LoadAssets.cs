using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    // Public variable for the red object prefab
    public GameObject redObj;

    // Private variable for the blue object prefab, visible in the Inspector
    [SerializeField]
    private GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate redObj at position (2, 0, 0) with no rotation
        Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);

        // Instantiate blueObj at position (-2, 0, 0) with no rotation
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);

        // Set the target frame rate to 60 fps
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
