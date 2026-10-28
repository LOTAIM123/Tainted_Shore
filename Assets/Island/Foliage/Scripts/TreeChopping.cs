using UnityEngine;

public class TreeChopping : MonoBehaviour, IHitable
{
    //[SerializeField] private GameObject treeChopped;
    [SerializeField] private GameObject drop;
    public void Execute()
    {
        //Instantiate(treeChopped, transform.position, transform.rotation);

        //drop amount
        for (int i = 0; i < 5; i++)
        {
          Instantiate(drop, transform.position, transform.rotation);  
        }
        Destroy(gameObject);
    }
}
