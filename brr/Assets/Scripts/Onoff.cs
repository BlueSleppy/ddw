using UnityEngine;

public class Onoff : MonoBehaviour
{
    [SerializeField] GameObject uwu;
    [SerializeField] GameObject uwu2;



    private void OnTriggerEnter(Collider other)
    {
        uwu.SetActive(true);
        uwu2.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
