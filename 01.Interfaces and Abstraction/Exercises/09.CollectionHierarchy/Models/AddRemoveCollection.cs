﻿namespace _09.CollectionHierarchy.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class AddRemoveCollection : IAddRemoveCollection
    {
        public AddRemoveCollection()
        {
            this.Items = new List<string>();
        }

        public List<string> Items { get; set; }

        public int Add(string item)
        {
            this.Items.Insert(0, item);
            return this.Items.IndexOf(item);
        }

        public string Remove()
        {
            var last = this.Items[this.Items.Count - 1];
            this.Items.Remove(last);
            return last;
        }
    }
}