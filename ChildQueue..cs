using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


    public class ChildQueue
    {
        private List<Child> children;

        public ChildQueue()
        {
            children = new List<Child>();
        }

        public List<Child> Children // Добавляем свойство Children
        {
            get { return children; }
        }
        public void AddChild(Child child)
    {
        children.Add(child);
    }

    public void RemoveChild(Child child)
    {
        children.Remove(child);
    }

    public void ClearQueue()
    {
        children.Clear();
    }

    public void SaveToFile(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, children);
        }
    }

    public void LoadFromFile(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            BinaryFormatter bf = new BinaryFormatter();
            children = (List<Child>)bf.Deserialize(fs);
        }
    }
}
