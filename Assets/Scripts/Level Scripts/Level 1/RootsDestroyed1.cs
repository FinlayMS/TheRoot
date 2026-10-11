using UnityEditor;
using UnityEngine;

public class RootsDestroyed1 : MonoBehaviour
{
    public GameObject allGone;
    private DestroyRoot destroyedBool;
    private int rootCount;
    public int rootsGoneTotal;

    void Start()
    {
        destroyedBool = allGone.GetComponent<DestroyRoot>();
    }

    void Update()
    {
        rootCount = AreRootsGone(rootCount);
        CountRoots();
    }

    public int AreRootsGone(int roots)
    {
        if (destroyedBool.destroyedRoot == true)
        {
            Debug.Log("roots gone =" + roots);
            roots += 1;
            Debug.Log("roots gone =" + roots);
            destroyedBool.destroyedRoot = false;
        }
        return roots;
    }
    public void CountRoots()
    {
        if (rootCount >= 3)
        {
            rootsGoneTotal += 1;
            Debug.Log("roots gone");
            rootCount = 0;
        }
    }
}
