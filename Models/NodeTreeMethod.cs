using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Models
{
    public class NodeTreeMethod
    {
        public string Data { get; set; }

        public List<NodeTreeMethod> Children { get; set; }

        public List<NodeTreeMethod> sorted = new List<NodeTreeMethod>();

        public List<string> pattern = new List<string>();

        public NodeTreeMethod(string data)
        {
            Data = data;
            Children = new List<NodeTreeMethod>();
        }

        public bool RemoveNode(NodeTreeMethod root, string data)
        {
            foreach (var child in root.Children)
            {
                if (child.Data == data)
                {
                    root.Children.Remove(child);
                    return true;
                }

                child.RemoveNode(child, data);
            }
            return false;
        }

        public bool AddNode(NodeTreeMethod root, string parentData, string childData)
        {
            if (root.Data == parentData)
            {
                root.Children.Add(new NodeTreeMethod(childData));
                return true;
            }
            foreach (var child in root.Children)
            {
                if (child.Data == parentData)
                {
                    child.Children.Add(new NodeTreeMethod(childData));

                    return true;
                }

                child.AddNode(child, parentData, childData);
            }
            return false;
        }

        public bool UpdateNode(NodeTreeMethod root, string oldData, string newData)
        {
            if (root.Data == oldData)
            {
                root.Data = newData;
                return true;
            }
            foreach (var child in root.Children)
            {
                if (child.Data == oldData)
                {
                    child.Data = newData;

                    return true;
                }

                child.UpdateNode(child, oldData, newData);
            }
            return false;
        }

        public bool CreatePatternAscending(NodeTreeMethod root, string nodeName, string sort)
        {
            if (root.Data == nodeName)
            {
                root.Children.ForEach(x => pattern.Add(x.Data));

                if (sort.ToLower() == "a-z")
                {
                    pattern.Sort();
                }
                else if(sort.ToLower() == "z-a")
                {
                    pattern.Sort();
                    pattern.Reverse();
                }

                return true;
            }

            foreach (var child in root.Children)
            {
                if (child.Data == nodeName)
                {
                    child.Children.ForEach(x => pattern.Add(x.Data));

                    if (sort.ToLower() == "asc")
                    {
                        pattern.Sort();
                    }
                    else if (sort.ToLower() == "dsc")
                    {
                        pattern.Sort();
                        pattern.Reverse();
                    }

                    return true;
                }

                child.CreatePatternAscending(child, nodeName, sort);
            }

            return false;
        }

        public bool SortNodes(NodeTreeMethod root, string nodeName, List<string> pattern)
        {
            if (root.Data == nodeName)
            {
                foreach (var item in pattern)
                {
                    for (var i = 0; i < root.Children.Count(); i++)
                    {
                        if (root.Children[i].Data == item)
                        {
                            sorted.Add(root.Children[i]);
                            break;
                        }
                    }
                }
                root.Children = sorted;
                return true;
            }

            foreach (var child in root.Children)
            {
                if (child.Data == nodeName)
                {
                    foreach (var item in pattern)
                    {
                        for (var i = 0; i < child.Children.Count(); i++)
                        {
                            if (child.Children[i].Data == item)
                            {
                                sorted.Add(child.Children[i]);
                                break;
                            }
                        }
                    }
                    child.Children = sorted;
                    return true;
                }

                child.SortNodes(child, nodeName, pattern);
            }

            return false;
        }
    }
}
