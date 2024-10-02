using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;
    
    [SerializeField]
    private LayerMask _layer;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Перемещаем персонажа в направлении _destination.
        _navMeshAgent.SetDestination(_destination);
        
        // TODO: Получите точку, по которой кликнули мышью и задайте ее вектор в поле _destination.
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hitInfo, 100f, _layer))
        {
            if (Input.GetMouseButtonDown(0))
            {
                _destination = hitInfo.point;
            }
        }
    }
}