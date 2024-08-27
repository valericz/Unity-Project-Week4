using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    
    // Public Renderer variable
    public Renderer rend;

    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
    }
}
