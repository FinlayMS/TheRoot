using UnityEngine;

public class OutlineMechanics : MonoBehaviour
{
    private void Start()
    {
        GameObject[] roots = GameObject.FindGameObjectsWithTag("Root");
        foreach (GameObject root in roots)
        {
            if (root.GetComponent<Outline>() == null)
            {
                root.AddComponent<Outline>();
                root.GetComponent<Outline>().enabled = false;
                root.GetComponent<Outline>().OutlineColor = new Color(173f, 216f, 230f); // set outline colour to light blue (rgb values)
                root.GetComponent<Outline>().OutlineWidth = 3f; // 3px wide outline
            }

            if (root.GetComponent<OutlineSelect>() == null)
            {
                root.AddComponent<OutlineSelect>();
            }

            if (root.GetComponent<BoxCollider>() == null)
            {
                root.AddComponent<BoxCollider>();
            }
        }
    }


}
