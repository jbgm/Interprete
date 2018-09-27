using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInterpreter.GenerickTree
{
    public class Node<Type>
    {
        public Node(Type value) 
        {
            this.Value = value;
            this.Children = new List<Node<Type>>();
        }

        public Node(Type value, ICollection<Node<Type>> children)
            : this(value) => this.Children = children;

        public Type Value { get; }
        public ICollection<Node<Type>> Children { get; }

        public Node<Type> Previous {get => this.Children.Count > 1 ? this.Children.ElementAt(0) : null;}

        public Node<Type> Next {get => this.Children.Count > 2 ? this.Children.ElementAt(1) : null;}

    }
}
