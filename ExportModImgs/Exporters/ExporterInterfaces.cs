﻿using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

namespace ExportModImgs.Exporters
{

    public interface IExportProvider<out T> where T : class
    {
        public T Provide(EntityDefinition entityDefinition);
    }

    public class DefinitionConsumer<T> : IExportProvider<T> where T : class
    {
        Func<EntityDefinition, T> provide;

        public DefinitionConsumer(Func<EntityDefinition, T> provide)
        {
            this.provide = provide;
        }

        public T Provide(EntityDefinition entityDefinition)
        {
            return provide(entityDefinition);
        }
    }


    public interface IPostConsume<in T> where T : class
    {
        public void Process(T input, string path);
    }

    public class EmptyPostConsume<T> : IPostConsume<T> where T : class
    {
        public void Process(T input, string path)
        {
            return;
        }
    }

    public interface IExPathProvider
    {
        public string ExSubDirs(EntityDefinition entityDefinition);

        public string ExportFilePrefix(EntityDefinition entityDefinition);

    }
}
