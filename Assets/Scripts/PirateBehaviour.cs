using UnityEngine;

public class PirateBehaviour : MonoBehaviour
{
    private int puntos;
    public int Puntos => puntos;

    void Start()
    {
        puntos = 0;
    }

    public void AddKey()
    {
        puntos += 1;
    }

    void OnTriggerStay(Collider other)
    {
        // Debug.Log("A collider is inside the DoorObject trigger");
    }

    void OnTriggerExit(Collider other)
    {
        // Debug.Log("A collider has exited the DoorObject trigger");
    }
}
