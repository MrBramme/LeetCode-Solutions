using System.Collections.Generic;

namespace LeetCode.Solutions.Medium
{
    // https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/
    public class GroupPeople
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var groupedPeople = new GroupedPeople();
            for (var person = 0; person < groupSizes.Length; person++)
            {
                groupedPeople.AddToGroup(person, groupSizes[person]);
            }

            return groupedPeople.Result;
        }

        class GroupedPeople
        {
            private readonly Dictionary<int, List<int>> _groups = new Dictionary<int, List<int>>();
            public readonly List<IList<int>> Result = new List<IList<int>>();

            public void AddToGroup(int person, int groupSize)
            {
                if (_groups.ContainsKey(groupSize))
                {
                    _groups[groupSize].Add(person);
                }
                else
                {
                    _groups.Add(groupSize, new List<int> { person });
                }
                if (_groups[groupSize].Count == groupSize)
                {
                    Result.Add(_groups[groupSize]);
                    _groups[groupSize] = new List<int>();
                }
            }
        }
    }
}
