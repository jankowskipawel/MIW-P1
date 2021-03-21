using System;
using System.Collections.Generic;
using System.Text;

namespace MIW_P1
{
    public class Dataset
    {
        public List<List<object>> attributes;
        public List<string> attributeTypes;
        public List<List<object>> normalizedAttributes;

        public Dataset()
        {
            attributes = new List<List<object>>();
            attributeTypes = new List<string>();
            normalizedAttributes = new List<List<object>>();
        }
    }
}
