using System;
using System.Collections.Generic;

namespace RTSLabCodeChallenge
{
    class RTSChallenge
    {
        public Dictionary<string, int> aboveBelow(List<int> l, int comp)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            int above = 0;
            int below = 0;
            foreach(int i in l)
            {
                if(i < comp)
                {
                    below++;
                } else if (i > comp)
                {
                    above++;
                }
            }
            result.Add("above", above);
            result.Add("below", below);
            return result;
        }

        public string stringRotation(string input, int rotation)
        {
            //Even though the propt says it will be positive rotations I added this check just to be sure
            if(rotation < 0)
            {
                throw new Exception("Invalid input - rotation amount is not positive. Value:" + rotation);
            }
            //% will remove the full rotations and leave only the part of the rotation that matters
            int change = rotation % input.Length;
            return input.Substring(input.Length - change, change) + input.Substring(0, input.Length - change);
        }
    }
}
