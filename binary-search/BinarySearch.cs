using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int GetMiddleIdx() => (int)Math.Round((float)input.Length / 2);

        if (input.Length == 0) return -1;
        if (input[0] == value) return 0;

        int idx, idxPre = -1, middleIdx;
        idx = middleIdx = GetMiddleIdx();

        while (input[middleIdx] != value)
        {
            if (value > input[middleIdx])
            {
                input = input[middleIdx..];
                middleIdx = GetMiddleIdx();
                idx += middleIdx;
            }
            else
            {
                input = input[..middleIdx];
                middleIdx = GetMiddleIdx();
                idx -= middleIdx;
            }

            if (idx == idxPre) return -1;
            idxPre = idx;
        }

        return idx;
    }
}