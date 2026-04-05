using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = GameManager.Instance.mainCam;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            SelectUnit(Input.mousePosition);
    }

    void SelectUnit(Vector2 pos)
    {
        Vector2 world = cam.ScreenToWorldPoint(pos);
        RaycastHit2D hit = Physics2D.Raycast(world, Vector2.zero);

        ClearSelection();

        if (hit.collider != null)
        {
            Unit u = hit.collider.GetComponent<Unit>();
            if (u != null)
                u.isSelected = true;
        }
    }

    void ClearSelection()
    {
        foreach (Unit u in FindObjectsOfType<Unit>())
            u.isSelected = false;
    }
}