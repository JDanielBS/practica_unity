using UnityEngine;

public class Unlocking : MonoBehaviour
{
    public GameObject Cabierto;
    public GameObject Ccerrado;
    public GameObject Moneda;
    [SerializeField] private int llavesRequeridas = 3;
    private bool cofreAbierto;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (cofreAbierto)
        {
            return;
        }

        if (!other.TryGetComponent(out PirateBehaviour player))
        {
            return;
        }

        if (player.Puntos >= llavesRequeridas)
        {
            if (Ccerrado != null) Ccerrado.SetActive(false);
            if (Cabierto != null) Cabierto.SetActive(true);
            if (Moneda != null) Moneda.SetActive(true);
            cofreAbierto = true;
        }
    }
}
