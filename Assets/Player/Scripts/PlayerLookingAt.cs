using UnityEngine;

public class PlayerLookingAt : MonoBehaviour
{
    [SerializeField] private float interactDistance = 3f;
    [SerializeField] private LayerMask interactMask = ~0;
    [SerializeField] private KeyCode interactKey = KeyCode.E;

    private IHitable currentTarget;

    private void Update()
    {
        FindTarget();

        if (currentTarget != null && Input.GetKeyDown(interactKey))
        {
            currentTarget.Execute();
            currentTarget = null;
        }
    }

    private void FindTarget()
    {
        currentTarget = null;

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance, interactMask, QueryTriggerInteraction.Ignore))
        {
            currentTarget = hit.collider.GetComponentInParent<IHitable>();
        }
    }
}