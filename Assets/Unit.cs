using UnityEngine;

public class Unit : MonoBehaviour
{
    public bool isSelected = false;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        sr.color = isSelected ? Color.green : Color.white;
    }
}