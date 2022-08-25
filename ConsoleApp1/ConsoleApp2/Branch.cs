using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Branch
    {
        private readonly int _val;
        public int Value { get { return _val; } }
        public List<Branch> branches = new List<Branch>();
        public int depth { get { return Depth(this); } }
        public int _depth;
        public Branch(int val)
        {
            _val = val;
        }
        public void CreateChild(int x)
        {
            var child = new Branch(x);
            branches.Add(child);
        }
        private int Depth(Branch branch)
        {
            if (branch == null) { return 0; }

            _depth = 0;
            foreach (Branch child in branch.branches)
            {
                _depth = Math.Max(_depth, Depth(child));
            }
            return _depth + 1;
        }
    }
}

