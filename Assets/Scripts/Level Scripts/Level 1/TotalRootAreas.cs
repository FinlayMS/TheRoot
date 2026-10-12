using UnityEditor;
using UnityEngine;

public class TotalRootAreas : MonoBehaviour
{
    public GameObject rootArea1;
    public GameObject rootArea2;
    public GameObject rootArea3;
    public GameObject rootArea4;
    public GameObject rootArea5;
    public GameObject rootArea6;

    private RootsDestroyed1 areaDestroyed1;
    private RootsDestroyed1 areaDestroyed2;
    private RootsDestroyed1 areaDestroyed3;
    private RootsDestroyed1 areaDestroyed4;
    private RootsDestroyed1 areaDestroyed5;
    private RootsDestroyed1 areaDestroyed6;

    public int totalRootAreasDestroyed;
    public bool activateLevel2Trigger;


    void Start()
    {
        areaDestroyed1 = rootArea1.GetComponent<RootsDestroyed1>();
        areaDestroyed2 = rootArea2.GetComponent<RootsDestroyed1>();
        areaDestroyed3 = rootArea3.GetComponent<RootsDestroyed1>();
        areaDestroyed4 = rootArea4.GetComponent<RootsDestroyed1>();
        areaDestroyed5 = rootArea5.GetComponent<RootsDestroyed1>();
        areaDestroyed6 = rootArea6.GetComponent<RootsDestroyed1>();
    }

    // Update is called once per frame
    void Update()
    {
        totalRootAreasDestroyed = AreRootAreasDestroyed(totalRootAreasDestroyed);
        activateLevel2Trigger = AllRootsDestroyed(totalRootAreasDestroyed, activateLevel2Trigger);
    }

    public int AreRootAreasDestroyed(int totalRoots)
    {
        if (areaDestroyed1.totalRootsBool == true)
        {
            totalRoots += 1;
            areaDestroyed1.totalRootsBool = false;
            Debug.Log("roots destroyed #" + totalRoots);
        }
        else if (areaDestroyed2.totalRootsBool == true)
        {
            totalRoots += 1;
            areaDestroyed2.totalRootsBool = false;
            Debug.Log("roots destroyed #" + totalRoots);
        }
        else if (areaDestroyed3.totalRootsBool == true)
        {
            totalRoots += 1;
            areaDestroyed3.totalRootsBool = false;
            Debug.Log("roots destroyed #" + totalRoots);
        }
        else if (areaDestroyed4.totalRootsBool == true)
        {
            totalRoots += 1;
            areaDestroyed4.totalRootsBool = false;
            Debug.Log("roots destroyed #" + totalRoots);
        }
        else if (areaDestroyed5.totalRootsBool == true)
        {
            totalRoots += 1;
            areaDestroyed5.totalRootsBool = false;
            Debug.Log("roots destroyed #" + totalRoots);
        }
        else if (areaDestroyed6.totalRootsBool == true)
        {
            totalRoots += 1;
            areaDestroyed6.totalRootsBool = false;
            Debug.Log("roots destroyed #" + totalRoots);
        }
        return totalRoots;
    }

    public bool AllRootsDestroyed(int totalRoots, bool activateLevel2)
    {
        if (totalRoots >= 6)
        {
            activateLevel2 = true;
            Debug.Log("all roots destroyed");
        }
        return activateLevel2;
    }
}
