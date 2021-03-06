﻿using System.Collections.Generic;

namespace Silent.Practices.MetadataProvider
{
    public class TypeCache
    {
        private readonly Dictionary<string, TypeMetadata> _typeContexts = new Dictionary<string, TypeMetadata>();

        public int Count => _typeContexts.Values.Count;

        public bool ContainsType(string typeName) => _typeContexts.ContainsKey(typeName);

        public TypeMetadata SetType(TypeMetadata type) => _typeContexts[type.TypeName] = type;

        public TypeMetadata GetType(string typeName) => _typeContexts.ContainsKey(typeName) ? _typeContexts[typeName] : null;

        public IEnumerable<TypeMetadata> GetTypes() => _typeContexts.Values;
    }
}