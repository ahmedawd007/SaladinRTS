using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private Unit unit;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        unit = GetComponent<Unit>();

        // مهم جدًا للـ 2D
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        if (!unit.isSelected) return;

        if (Input.GetMouseButtonUp(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPos.z = 0;

            agent.SetDestination(worldPos);
        }
    }
}