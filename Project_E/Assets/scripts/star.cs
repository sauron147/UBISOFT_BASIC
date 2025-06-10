using UnityEngine;

public class StarPhases : MonoBehaviour
{
    
    private const string fullSpace = "　";

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    void Phase1()
    {
        string result = "▶ Phase 1\n";

        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x <= y; x++)
                result += "★";

            result += "\n";
        }

        Debug.Log(result);
    }

    void Phase2()
    {
        string result = "▶ Phase 2\n";

        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 4 - y; x++)
                result += fullSpace;

            for (int x = 0; x <= y; x++)
                result += "★";

            result += "\n";
        }

        Debug.Log(result);
    }

    void Phase3()
    {
        string result = "▶ Phase 3\n";

        for (int y = 0; y < 9; y++)
        {
            int stars = 0;

            if (y <= 4)
                stars = y + 1;
            else
                stars = 9 - y;

            for (int x = 0; x < stars; x++)
                result += "★";

            result += "\n";
        }

        Debug.Log(result);
    }

    void Phase4()
    {
        string result = "▶ Phase 4\n";

        for (int y = 0; y < 9; y++)
        {
            int spaceCount = 0;
            int starCount = 0;

            if (y <= 4)
            {
                spaceCount = 4 - y;
                starCount = y + 1;
            }
            else
            {
                spaceCount = y - 4;
                starCount = 9 - y;
            }

            for (int i = 0; i < spaceCount; i++)
                result += fullSpace;

            for (int j = 0; j < starCount; j++)
                result += "★";

            result += "\n";
        }

        Debug.Log(result);
    }

    void Phase5()
    {
        string result = "▶ Phase 5\n";

        for (int y = 0; y < 9; y++)
        {
            int spaceCount = 0;
            int starCount = 0;

            if (y <= 4)
            {
                spaceCount = 4 - y;
                starCount = y + 1;
            }
            else
            {
                spaceCount = y - 4;
                starCount = 9 - y;
            }

            for (int i = 0; i < spaceCount; i++)
                result += fullSpace;

            for (int j = 0; j < starCount * 2 - 1; j++)
                result += "★";

            result += "\n";
        }

        Debug.Log(result);
    }
}