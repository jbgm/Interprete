using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInterpreter.GenerickTree
{
    public class TreeNode <Type> : Node<Type>
    {
        public TreeNode(Type value, int index)
            : base (value) => this.Index = index;

        public TreeNode(Type value, int index, ICollection<Node<Type>> children)
            : base(value, children) => this.Index = index;

        public int Index { get; }
    }
}
