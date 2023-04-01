using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        int Level = 10;
        float HP = 24.5f;
        double MP = 56.1f;
        bool is_next_level = false;

        if (is_next_level)
            Debug.Log("다음 레벨로 넘어갑니다.");
        else
            Debug.Log("아직 다음 레벨로 못 넘어갑니다.");

        for(int i = 0; i < Level; i++)
            Debug.Log(i + 1 + "번째 숫자");

        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
            arr[i] = i+1;

        for (int i = 0; i < 5; i++)
            Debug.Log((i + 1) + "번째 숫자는" + arr[i]);

        List<int> list = new List<int>();
        list.Add(12);
        list.Add(56);
        list.Add(96);

        foreach (int i in list)
            Debug.Log(i);
        */
        Class2 people = new Class2();
        people.age = 10;
        people.height = 165.7f;
        people.name = "sklfjasdklj";
        people.Print2();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
