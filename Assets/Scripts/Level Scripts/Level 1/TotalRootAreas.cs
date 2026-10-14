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
        totalRootAreasDestroyed = AreRootAreasDestroyed1(totalRootAreasDestroyed);
        totalRootAreasDestroyed = AreRootAreasDestroyed2(totalRootAreasDestroyed);
        activateLevel2Trigger = AllRootsDestroyed(totalRootAreasDestroyed, activateLevel2Trigger);
    }

    public int AreRootAreasDestroyed1(int totalRoots)
    {
        if (areaDestroyed1.totalRootsDestroyed == 1)
        {
            totalRoots += 1;
            Debug.Log("root area 1, roots destroyed #" + totalRoots);
            rootArea1.SetActive(false);
        }
        else if (areaDestroyed2.totalRootsDestroyed == 1)
        {
            totalRoots += 1;
            areaDestroyed2.totalRootsDestroyed = 0;
            Debug.Log("root area 2, roots destroyed #" + totalRoots);
            rootArea2.SetActive(false);
        }
        else if (areaDestroyed3.totalRootsDestroyed == 1)
        {
            totalRoots += 1;
            areaDestroyed3.totalRootsDestroyed = 0;
            Debug.Log("root area 3, roots destroyed #" + totalRoots);
            rootArea3.SetActive(false);
        }
        return totalRoots;
    }

    public int AreRootAreasDestroyed2(int totalRoots)
    {
        if (areaDestroyed4.totalRootsDestroyed == 1)
        {
            totalRoots += 1;
            areaDestroyed4.totalRootsDestroyed = 0;
            Debug.Log("root area 4, roots destroyed #" + totalRoots);
            rootArea4.SetActive(false);
        }
        else if (areaDestroyed5.totalRootsDestroyed == 1)
        {
            totalRoots += 1;
            areaDestroyed5.totalRootsDestroyed = 0;
            Debug.Log("root area 5, roots destroyed #" + totalRoots);
            rootArea5.SetActive(false);
        }
        else if (areaDestroyed6.totalRootsDestroyed == 1)
        {
            totalRoots += 1;
            areaDestroyed6.totalRootsDestroyed = 0;
            Debug.Log("root area 6, roots destroyed #" + totalRoots);
            rootArea6.SetActive(false);
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
