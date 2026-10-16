using UnityEditor;
using UnityEngine;

public class RootsDestroyed1 : MonoBehaviour
{
    public int rootCount;
    public int totalRootsDestroyed;
    public bool byebyeText = false;
    public bool allRootsDestroyed = false;
    private DestroyRoot[] _roots;

    void Awake()
    {
        _roots = new DestroyRoot[transform.childCount];
        for (int i = 0; i < _roots.Length; i++)
            _roots[i] = transform.GetChild(i).GetComponent<DestroyRoot>();

        _roots = GetComponentsInChildren<DestroyRoot>();
    }

    void Update()
    {
        rootCount = AreRootsGone(rootCount);
        totalRootsDestroyed = UpdateTotalRoots(rootCount, totalRootsDestroyed);
        byebyeText = UpdateTextBool(rootCount, byebyeText);
        rootCount = ResetRoots(rootCount);
    }

    public int AreRootsGone(int roots)
    {
        foreach (DestroyRoot root in _roots)
        {
            if (root.destroyedRoot == true)
            {
                roots += 1;
                Debug.Log("roots gone =" + roots);
                root.destroyedRoot = false;
            }
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
    public bool UpdateTextBool(int roots, bool byeText)
    {
        if (roots == 3)
        {
            Debug.Log("updated total roots");
            byeText = true;
        }
        return byeText;
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
