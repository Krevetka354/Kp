using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class ChildQueue
{
    public List<Child> Children { get; set; }

    public ChildQueue()
    {
        Children = new List<Child>();
    }
        public void AddChild(Child child)
        {
            Children.Add(child);
        }

        public void RemoveChild(Child child)
        {
            Children.Remove(child);
        }

        public void ClearQueue()
        {
            Children.Clear();
        }

        public void SaveToFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Children);
            }
        }

        public void LoadFromFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Children = (List<Child>)formatter.Deserialize(fs);
            }
        }
    }



