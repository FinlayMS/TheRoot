using UnityEditor;
using UnityEngine;

public class RootsDestroyed1 : MonoBehaviour
{
    public GameObject root1;
    public GameObject root2;
    public GameObject root3;

    private DestroyRoot destroyedBool1;
    private DestroyRoot destroyedBool2;
    private DestroyRoot destroyedBool3;

    public int rootCount;
    public bool totalRootsBool = false;
    public int totalRootsDestroyed;
    public bool allRootsDestroyed = false;

    void Start()
    {
        destroyedBool1 = root1.GetComponent<DestroyRoot>();
        destroyedBool2 = root2.GetComponent<DestroyRoot>();
        destroyedBool3 = root3.GetComponent<DestroyRoot>();
    }

    void Update()
    {
        rootCount = AreRootsGone(rootCount);
        totalRootsDestroyed = UpdateTotalRoots(rootCount, totalRootsDestroyed);
        rootCount = ResetRoots(rootCount);
    }

    public int AreRootsGone(int roots)
    {
        if (destroyedBool1.destroyedRoot == true)
        {
            roots += 1;
            Debug.Log("roots gone =" + roots );
            destroyedBool1.destroyedRoot = false;
        }
        else if (destroyedBool2.destroyedRoot == true)
        {
            roots += 1;
            Debug.Log("roots gone =" + roots);
            destroyedBool2.destroyedRoot = false;
        }
        else if (destroyedBool3.destroyedRoot == true)
        {
            roots += 1;
            Debug.Log("roots gone =" + roots);
            destroyedBool3.destroyedRoot = false;
        }
        return roots;
    }

    public int UpdateTotalRoots(int roots, int totalRoots)
    {
        if (roots == 3)
        {
            Debug.Log("updated total roots");
            totalRoots += 1;
        }
        return totalRoots;
    }

    public int ResetRoots(int roots)
    {
        if (roots == 3)
        {
            roots = 0;
            Debug.Log("reset roots");
        }
        return roots;
    }


}
