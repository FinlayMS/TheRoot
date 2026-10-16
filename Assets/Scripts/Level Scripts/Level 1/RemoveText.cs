using UnityEngine;

public class RemoveText : MonoBehaviour
{
    public GameObject totalRootCounter;
    private TotalRootAreas totalRoots;

    private void Start()
    {
        totalRoots = totalRootCounter.GetComponent<TotalRootAreas>();
    }

    void Update()
    {
        if (totalRoots.hideText == true)
        {
            Destroy(gameObject);
        }
    }
}
