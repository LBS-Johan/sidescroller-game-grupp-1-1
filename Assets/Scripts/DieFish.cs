using UnityEngine;
public class Diefish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    [SerializeField]
    int TimeBeforeDeath = 0;
    // Update is called once per frame
    void Update()
    {
        TimeBeforeDeath--;
        if (TimeBeforeDeath == 0)
        {
            Destroy(gameObject);
        }
    }
}
