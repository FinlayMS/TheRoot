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
    public bool hideText;
    public bool activateLevel2Trigger;


    void Start()
    {
        areaDestroyed1 = rootArea1.GetComponent<RootsDestroyed1>();
        areaDestroyed2 = rootArea2.GetComponent<RootsDestroyed1>();
        areaDestroyed3 = rootArea3.GetComponent<RootsDestroyed1>();
        areaDestroyed4 = rootArea4.GetComponent<RootsDestroyed1>();
        areaDestroyed5 = rootArea5.GetComponent<RootsDestroyed1>();
        areaDestroyed6 = rootArea6.GetComponent<RootsDestroyed1>();

        hideText = false;
    }

    void Update()
    {
        totalRootAreasDestroyed = AreRootAreasDestroyed(totalRootAreasDestroyed);
        activateLevel2Trigger = AllRootsDestroyed(activateLevel2Trigger);
        hideText = HideRootText(hideText);
    }

    public int AreRootAreasDestroyed(int totalRoots)
    {
        if (areaDestroyed1.totalRootsDestroyed == 1)
        {
            totalRoots += 1;
            areaDestroyed1.totalRootsDestroyed = 0;
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


    public bool AllRootsDestroyed(bool activateLevel2)
    {
        if (rootArea1.activeSelf == false && rootArea2.activeSelf == false && rootArea3.activeSelf == false && rootArea4.activeSelf == false && rootArea5.activeSelf == false && rootArea6.activeSelf == false)
        {
            Debug.Log("ooga booga all roots gone");
            activateLevel2 = true;
        }
        return activateLevel2;
    }

    public bool HideRootText(bool hideTheText)
    {
        if (areaDestroyed1.byebyeText == true || areaDestroyed2.byebyeText == true || areaDestroyed3.byebyeText == true || areaDestroyed4.byebyeText == true || areaDestroyed5.byebyeText == true || areaDestroyed6.byebyeText == true)
        {
            hideTheText = true;
        }
        return hideTheText;
    }
}
